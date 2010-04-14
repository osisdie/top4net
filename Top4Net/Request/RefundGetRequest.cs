using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.refund.get
    /// </summary>
    public class RefundGetRequest : ITopRequest
    {
        public string Fields { get; set; }
        public Nullable<long> RefundId { get; set; }
        public string V { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.refund.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("refund_id", this.RefundId);
            parameters.Add("v", this.V);
            return parameters;
        }

        #endregion
    }
}
