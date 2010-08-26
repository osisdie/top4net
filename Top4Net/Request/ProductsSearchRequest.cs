using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.products.search
    /// </summary>
    public class ProductsSearchRequest : ITopRequest
    {
        public Nullable<long> Cid { get; set; }
        public string Fields { get; set; }
        public Nullable<int> PageNo { get; set; }
        public Nullable<int> PageSize { get; set; }
        public string Props { get; set; }
        public string Q { get; set; }
        public string Status { get; set; }
        public Nullable<long> VerticalMarket { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.products.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("fields", this.Fields);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("props", this.Props);
            parameters.Add("q", this.Q);
            parameters.Add("status", this.Status);
            parameters.Add("vertical_market", this.VerticalMarket);
            return parameters;
        }

        #endregion
    }
}
