using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sns.activity.add
    /// </summary>
    public class SnsActivityAddRequest : ITopRequest
    {
        /// <summary>
        /// 动态信息。
        /// </summary>
        public string Content { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sns.activity.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("content", this.Content);

            return parameters;
        }

        #endregion
    }
}
