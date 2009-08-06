using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sns.user.get
    /// </summary>
    public class SnsUserGetRequest : ITopRequest
    {
        /// <summary>
        /// 用户编号。
        /// </summary>
        public string Uid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sns.user.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("uid", this.Uid);

            return parameters;
        }

        #endregion
    }
}
