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
