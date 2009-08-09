﻿using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 产品的JSON响应解释器。
    /// </summary>
    public class ProductJsonParser : ITopParser<Product>
    {
        #region ITopParser<Product> Members

        public Product Parse(string body)
        {
            ITopParser<ResponseList<Product>> parser = new ProductListJsonParser();
            List<Product> products = parser.Parse(body).Content;

            if (products != null && products.Count > 0)
            {
                return products[0];
            }
            else
            {
                return null;
            }
        }

        #endregion
    }


    /// <summary>
    /// 产品列表的JSON响应解释器。
    /// </summary>
    public class ProductListJsonParser : ITopParser<ResponseList<Product>>
    {
        #region ITopParser<ResponseList<Product>> Members

        public ResponseList<Product> Parse(string body)
        {
            ResponseList<Product> rspList = new ResponseList<Product>();

            JObject jsonBody = JObject.Parse(body);
            JArray jsonProducts = jsonBody["rsp"]["products"] as JArray;
            rspList.TotalResults = jsonBody["rsp"].Value<long>("totalResults");

            if (jsonProducts != null)
            {
                List<Product> products = new List<Product>();
                for (int i = 0; i < jsonProducts.Count; i++)
                {
                    JsonSerializer js = new JsonSerializer();
                    object product = js.Deserialize(jsonProducts[i].CreateReader(), typeof(Product));
                    products.Add(product as Product);
                }
                rspList.Content = products;
            }

            return rspList;
        }

        #endregion
    }

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
