using System;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// TOP响应。
    /// </summary>
    /// <typeparam name="T">任何一种可序列化的领域对象</typeparam>
    [Serializable]
    [XmlRoot("rsp")]
    public class Response<T>
    {
        /// <summary>
        /// 解释后的具体对象。
        /// </summary>
        public T Content { get; set; }
    }
}
