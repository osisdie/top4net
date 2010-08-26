using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.increment.user.authorize
    /// </summary>
    public class IncrementUserAuthorizeRequest : ITopRequest
    {
        public Nullable<int> Duration { get; set; }
        public string Email { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.increment.user.authorize";
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
