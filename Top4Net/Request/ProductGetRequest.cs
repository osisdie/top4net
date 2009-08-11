using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.get
    /// </summary>
    public class ProductGetRequest : ITopRequest
    {
        /// <summary>
        /// 要返回的产品字段列表。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 产品编号。
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 商品类目编号。
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 关键属性列表。
        /// </summary>
        public string Props { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("cid", this.Cid);
            parameters.Add("props", this.Props);

            return parameters;
        }

        #endregion
    }
}
