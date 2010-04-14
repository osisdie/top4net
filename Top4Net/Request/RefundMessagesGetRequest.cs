using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.refund.messages.get
    /// </summary>
    public class RefundMessagesGetRequest : ITopRequest
    {
        public string Fields { get; set; }
        public Nullable<int> PageNo { get; set; }
        public Nullable<int> PageSize { get; set; }
        public Nullable<long> RefundId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.refund.messages.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("refund_id", this.RefundId);
            return parameters;
        }

        #endregion
    }
}
