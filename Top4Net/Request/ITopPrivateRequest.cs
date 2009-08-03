using System;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP私有API请求接口。
    /// </summary>
    public interface ITopPrivateRequest : ITopRequest
    {
        /// <summary>
        /// 获取用户会话授权码。
        /// </summary>
        /// <returns></returns>
        string GetSessionKey();
    }
}
