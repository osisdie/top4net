using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// TOP响应列表。
    /// </summary>
    /// <typeparam name="T">任何一种可序列化的领域对象列表</typeparam>
    [Serializable]
    [XmlRoot("rsp")]
    public class TopListResponse<T>
    {
        private string element;
        public List<T> Content { get; set; }

        public TopListResponse() { }

        public TopListResponse(string element)
        {
            this.element = element;
        }

        public XmlAttributeOverrides GetOverrides()
        {
            XmlAttributes attrs = new XmlAttributes();
            attrs.XmlElements.Add(new XmlElementAttribute(this.element, typeof(T)));
            XmlAttributeOverrides attrOvrs = new XmlAttributeOverrides();
            attrOvrs.Add(typeof(TopListResponse<T>), "Content", attrs);
            return attrOvrs;
        }
    }
}
