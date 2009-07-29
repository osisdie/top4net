using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 产品列表对象的JSON响应解释器。
    /// </summary>
    public class ProductListJsonParser : ITopParser<List<Product>>
    {
        #region ITopParser<List<Product>> Members

        public List<Product> Parse(string body)
        {
            List<Product> products = new List<Product>();

            JObject jsonBody = JObject.Parse(body);
            JArray jsonProducts = jsonBody["rsp"]["products"] as JArray;

            if (jsonProducts != null)
            {
                for (int i = 0; i < jsonProducts.Count; i++)
                {
                    JsonSerializer js = new JsonSerializer();
                    object product = js.Deserialize(jsonProducts[i].CreateReader(), typeof(Product));
                    products.Add(product as Product);
                }
            }

            return products;
        }

        #endregion
    }
}
