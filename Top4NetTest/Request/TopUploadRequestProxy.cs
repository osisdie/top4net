using System;
using System.Collections.Generic;

using Taobao.Top.Api.Request;

namespace Taobao.Top.Api.Test.Request
{
    /// <summary>
    /// TOP带文件上传API请求代理。
    /// </summary>
    public class TopUploadRequestProxy : TopPrivateRequestProxy, ITopUploadRequest
    {
        private ITopUploadRequest request;

        public TopUploadRequestProxy(ITopUploadRequest request, string nick)
            : base(request, nick)
        {
            this.request = request;
        }

        #region ITopUploadRequest Members

        public IDictionary<string, string> GetFileParameters()
        {
            return request.GetFileParameters();
        }

        #endregion
    }
}
