using System;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP私有API请求接口。
    /// </summary>
    public interface ITopPrivateRequest : ITopRequest
    {
        string GetSessionKey();
    }
}
