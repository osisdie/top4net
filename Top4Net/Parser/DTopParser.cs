using System;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// TOP API响应解释器委托。响应格式可以是XML, JSON等等。
    /// </summary>
    /// <typeparam name="T">领域对象</typeparam>
    /// <param name="body">TOP API响应字符串</param>
    /// <returns>领域对象</returns>
    public delegate T DTopParser<T>(string body);
}
