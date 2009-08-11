using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sns.message.send
    /// </summary>
    public class SnsMessageSendRequest : ITopRequest
    {
        /// <summary>
        /// 接收者编号。
        /// </summary>
        public string ReceiverId { get; set; }

        /// <summary>
        /// 动态信息。
        /// </summary>
        public string Content { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sns.message.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("id", this.ReceiverId);
            parameters.Add("content", this.Content);

            return parameters;
        }

        #endregion
    }
}
