using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.users.get
    /// </summary>
    public class UsersGetRequest : ITopRequest
    {
        public string Fields { get; set; }
        public string Nicks { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.users.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("nicks", this.Nicks);
            return parameters;
        }

        #endregion
    }
}
