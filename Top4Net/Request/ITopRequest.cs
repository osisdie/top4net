using System;
using System.Collections.Generic;
using System.Text;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP请求接口。
    /// </summary>
    public interface ITopRequest
    {
        /// <summary>
        /// 获取TOP的API名称。
        /// </summary>
        /// <returns>API名称</returns>
        string GetApiName();

        /// <summary>
        /// 获取所有的Key-Value形式的请求参数字典。
        /// </summary>
        /// <returns>请求参数字典</returns>
        IDictionary<string, string> GetParameters();
    }
}
