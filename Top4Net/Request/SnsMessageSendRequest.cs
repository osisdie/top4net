using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sns.message.send
    /// </summary>
    public class SnsMessageSendRequest : ITopPrivateRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 接收者id。
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 动态信息。
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 产品主图文件绝对地址。
        /// </summary>
        public string PrimaryPicPath { get; set; }

        public SnsMessageSendRequest(string sessionKey)
        {
            if (string.IsNullOrEmpty(sessionKey))
            {
                throw new ArgumentNullException("sessionKey");
            }
            this.sessionKey = sessionKey;
        }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sns.message.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("id", this.Id);
            parameters.Add("content", this.Content);

            return parameters;
        }

        #endregion

        #region ITopPrivateRequest Members

        public string GetSessionKey()
        {
            return this.sessionKey;
        }

        #endregion
    }
}
