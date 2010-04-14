using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.notify.app.subscribe
    /// </summary>
    public class NotifyAppSubscribeRequest : ITopRequest
    {
        public Nullable<long> Duration { get; set; }
        public string Status { get; set; }
        public string Topics { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.notify.app.subscribe";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("duration", this.Duration);
            parameters.Add("status", this.Status);
            parameters.Add("topics", this.Topics);
            return parameters;
        }

        #endregion
    }
}
