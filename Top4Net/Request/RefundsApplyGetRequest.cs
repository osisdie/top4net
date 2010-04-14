using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.refunds.apply.get
    /// </summary>
    public class RefundsApplyGetRequest : ITopRequest
    {
        public string Fields { get; set; }
        public Nullable<int> PageNo { get; set; }
        public Nullable<int> PageSize { get; set; }
        public string SellerNick { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.refunds.apply.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.Add("status", this.Status);
            parameters.Add("type", this.Type);
            return parameters;
        }

        #endregion
    }
}
