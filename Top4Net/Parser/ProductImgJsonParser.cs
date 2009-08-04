using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 产品图片的JSON响应解释器。
    /// </summary>
    public class ProductImgJsonParser : ITopParser<ProductImg>
    {
        #region ITopParser<ProductImg> Members

        public ProductImg Parse(string body)
        {
            List<ProductImg> productImgs = new List<ProductImg>();

            JObject jsonBody = JObject.Parse(body);
            JArray jsonProductImgs = jsonBody["rsp"]["productImgs"] as JArray;

            if (jsonProductImgs != null)
            {
                for (int i = 0; i < jsonProductImgs.Count; i++)
                {
                    JsonSerializer js = new JsonSerializer();
                    object productImg = js.Deserialize(jsonProductImgs[i].CreateReader(), typeof(ProductImg));
                    productImgs.Add(productImg as ProductImg);
                }
            }

            return productImgs.Count == 0 ? null : productImgs[0];
        }

        #endregion
    }
}
