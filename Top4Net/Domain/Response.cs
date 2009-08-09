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
        public T Content { get; set; }

        /// <summary>
        /// 根据指定的名字重写对象标签的名字。
        /// </summary>
        /// <param name="element">标签名字</param>
        /// <returns>重写逻辑</returns>
        public static XmlAttributeOverrides GetOverrides(string element)
        {
            XmlAttributes attrs = new XmlAttributes();
            attrs.XmlElements.Add(new XmlElementAttribute(element, typeof(T)));
            XmlAttributeOverrides attrOvrs = new XmlAttributeOverrides();
            attrOvrs.Add(typeof(Response<T>), "Content", attrs);
            return attrOvrs;
        }
    }
}
