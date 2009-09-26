using System;
using System.IO;
using System.Collections.Generic;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Test
{
    /// <summary>
    /// TOP内部API请求代理，仅用于内部测试。
    /// </summary>
    public class TopRequestProxy : ITopRequest
    {
        private ITopRequest request;
        private string nick;

        public TopRequestProxy(ITopRequest request, string nick)
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
            parameters.Add("session", Guid.NewGuid().ToString());
            parameters.Add("session_id", Guid.NewGuid().ToString());
            parameters.Add("session_nick", this.nick);
            return parameters;
        }

        #endregion
    }

    /// <summary>
    /// TOP内部上传API请求代理，仅用于内部测试。
    /// </summary>
    public class TopUploadRequestProxy : TopRequestProxy, ITopUploadRequest
    {
        private ITopUploadRequest request;

        public TopUploadRequestProxy(ITopUploadRequest request, string nick)
            : base(request, nick)
        {
            this.request = request;
        }

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return request.GetFileParameters();
        }

        #endregion
    }
}
