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
    public class TopResponse<T>
    {
        private string element;
        public T Content { get; set; }

        public TopResponse() { }

        public TopResponse(string element)
        {
            this.element = element;
        }

        public XmlAttributeOverrides GetOverrides()
        {
            XmlAttributes attrs = new XmlAttributes();
            attrs.XmlElements.Add(new XmlElementAttribute(this.element, typeof(T)));
            XmlAttributeOverrides attrOvrs = new XmlAttributeOverrides();
            attrOvrs.Add(typeof(TopResponse<T>), "Content", attrs);
            return attrOvrs;
        }
    }
}
