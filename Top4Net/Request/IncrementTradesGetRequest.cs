using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.increment.trades.get
    /// </summary>
    public class IncrementTradesGetRequest : ITopRequest
    {
        public Nullable<DateTime> EndModified { get; set; }
        public string Nick { get; set; }
        public Nullable<int> PageNo { get; set; }
        public Nullable<int> PageSize { get; set; }
        public Nullable<DateTime> StartModified { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.increment.trades.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_modified", this.EndModified);
            parameters.Add("nick", this.Nick);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_modified", this.StartModified);
            parameters.Add("status", this.Status);
            parameters.Add("type", this.Type);
            return parameters;
        }

        #endregion
    }
}
