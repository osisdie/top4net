using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sns.picture.setUsed
    /// </summary>
    public class SnsPictureUseRequest : ITopPrivateRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 图片文件ids，例如：value1,value2,value3。
        /// </summary>
        public string Ids { get; set; }

        /// <summary>
        /// 产品主图文件绝对地址。
        /// </summary>
        public string PrimaryPicPath { get; set; }

        public SnsPictureUseRequest(string sessionKey)
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
            return "taobao.sns.picture.setUsed";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("ids", this.Ids);

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
