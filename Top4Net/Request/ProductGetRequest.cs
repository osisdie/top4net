using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.get
    /// </summary>
    public class ProductGetRequest : ITopRequest
    {
        public Nullable<long> Cid { get; set; }
        public string Fields { get; set; }
        public Nullable<long> ProductId { get; set; }
        public string Props { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("fields", this.Fields);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("props", this.Props);
            return parameters;
        }

        #endregion
    }
}
