using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP上传请求接口。
    /// </summary>
    public interface ITopUploadRequest : ITopPrivateRequest
    {
        /// <summary>
        /// 获取所有的Key-Value形式的文件请求参数字典。其中：
        /// Key: 请求参数名
        /// Value: 文件路径名
        /// </summary>
        /// <returns>文件请求参数字典</returns>
        IDictionary<string, string> GetFileParameters();
    }
}
