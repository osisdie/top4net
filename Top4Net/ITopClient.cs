using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Request;

namespace Taobao.Top.Api
{
    /// <summary>
    /// TOP客户端。
    /// </summary>
    public interface ITopClient
    {
        /// <summary>
        /// 执行TOP公开API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的TOP API请求</param>
        /// <param name="parser">与API请求响应相对应的解释器接口实现</param>
        /// <returns>领域对象</returns>
        T Execute<T>(ITopRequest request, ITopParser<T> parser);

        /// <summary>
        /// 执行TOP隐私API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的TOP API请求</param>
        /// <param name="parser">与API请求响应相对应的解释器接口实现</param>
        /// <param name="session">用户会话码</param>
        /// <returns>领域对象</returns>
        T Execute<T>(ITopRequest request, ITopParser<T> parser, string session);
    }
}
