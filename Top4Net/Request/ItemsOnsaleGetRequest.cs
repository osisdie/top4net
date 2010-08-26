using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.items.onsale.get
    /// </summary>
    public class ItemsOnsaleGetRequest : ITopRequest
    {
        public Nullable<long> Cid { get; set; }
        public Nullable<DateTime> EndModified { get; set; }
        public string Fields { get; set; }
        public Nullable<bool> HasDiscount { get; set; }
        public Nullable<bool> HasShowcase { get; set; }
        public Nullable<bool> IsEx { get; set; }
        public Nullable<bool> IsTaobao { get; set; }
        public string OrderBy { get; set; }
        public Nullable<int> PageNo { get; set; }
        public Nullable<int> PageSize { get; set; }
        public string Q { get; set; }
        public string SellerCids { get; set; }
        public Nullable<DateTime> StartModified { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.items.onsale.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("end_modified", this.EndModified);
            parameters.Add("fields", this.Fields);
            parameters.Add("has_discount", this.HasDiscount);
            parameters.Add("has_showcase", this.HasShowcase);
            parameters.Add("is_ex", this.IsEx);
            parameters.Add("is_taobao", this.IsTaobao);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("q", this.Q);
            parameters.Add("seller_cids", this.SellerCids);
            parameters.Add("start_modified", this.StartModified);
            return parameters;
        }

        #endregion
    }
}
