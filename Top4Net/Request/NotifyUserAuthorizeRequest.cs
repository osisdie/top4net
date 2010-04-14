using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.notify.user.authorize
    /// </summary>
    public class NotifyUserAuthorizeRequest : ITopRequest
    {
        public Nullable<long> Duration { get; set; }
        public string Email { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.notify.user.authorize";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("duration", this.Duration);
            parameters.Add("email", this.Email);
            return parameters;
        }

        #endregion
    }
}
