using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 产品对象的JSON响应解释器。
    /// </summary>
    public class ProductJsonParser : ITopParser<Product>
    {
        #region ITopParser<Product> Members

        public Product Parse(string body)
        {
            ITopParser<List<Product>> parser = new ProductListJsonParser();
            List<Product> products = parser.Parse(body);

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
}
