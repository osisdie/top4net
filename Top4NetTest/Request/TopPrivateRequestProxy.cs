using System;
using System.Collections.Generic;

using Taobao.Top.Api.Request;

namespace Taobao.Top.Api.Test
{
    /// <summary>
    /// TOP私有API请求代理。
    /// </summary>
    public class TopPrivateRequestProxy : ITopPrivateRequest
    {
        private ITopPrivateRequest request;
        private string nick;

        public TopPrivateRequestProxy(ITopPrivateRequest request, string nick)
        {
            this.request = request;
            this.nick = nick;
        }

        #region ITopRequest Members

        public string GetApiName()
        {
            return request.GetApiName();
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = request.GetParameters();
            parameters.Add("session_nick", this.nick);
            parameters.Add("session_id", Guid.NewGuid().ToString());
            return parameters;
        }

        #endregion

        #region ITopPrivateRequest Members

        public string GetSessionKey()
        {
            return request.GetSessionKey();
        }

        #endregion
    }
}
