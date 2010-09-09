using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.increment.app.subscribe
    /// </summary>
    public class IncrementAppSubscribeRequest : ITopRequest
    {
        public Nullable<int> Duration { get; set; }
        public string IsNotify { get; set; }
        public string NotifyUrl { get; set; }
        public string Status { get; set; }
        public string Topics { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.increment.app.subscribe";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("duration", this.Duration);
            parameters.Add("is_notify", this.IsNotify);
            parameters.Add("notify_url", this.NotifyUrl);
            parameters.Add("status", this.Status);
            parameters.Add("topics", this.Topics);
            return parameters;
        }

        #endregion
    }
}
