using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.increment.xiaoer.subscribe
    /// </summary>
    public class IncrementXiaoerSubscribeRequest : ITopRequest
    {
        public Nullable<int> Duration { get; set; }
        public string IsvAppKey { get; set; }
        public string Status { get; set; }
        public string Topics { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.increment.xiaoer.subscribe";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("duration", this.Duration);
            parameters.Add("isv_app_key", this.IsvAppKey);
            parameters.Add("status", this.Status);
            parameters.Add("topics", this.Topics);
            return parameters;
        }

        #endregion
    }
}
