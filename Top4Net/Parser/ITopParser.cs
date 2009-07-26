using System;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// TOP API响应解释器. 响应格式可以是XML, JSON等等.
    /// </summary>
    /// <typeparam name="T">领域对象</typeparam>
    public interface ITopParser<T>
    {
        T Parse(string body);
    }
}
