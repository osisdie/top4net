using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// TOP响应列表。
    /// </summary>
    /// <typeparam name="T">任何一种可序列化的领域对象列表</typeparam>
    [Serializable]
    [XmlRoot("rsp")]
    public class ResponseList<T>
    {
        [JsonProperty("totalResults")]
        [XmlElement("totalResults")]
        public long TotalResults { get; set; }

        public List<T> Content { get; set; }

        public static XmlAttributeOverrides GetOverrides(string element)
        {
            XmlAttributes attrs = new XmlAttributes();
            attrs.XmlElements.Add(new XmlElementAttribute(element, typeof(T)));
            XmlAttributeOverrides attrOvrs = new XmlAttributeOverrides();
            attrOvrs.Add(typeof(ResponseList<T>), "Content", attrs);
            return attrOvrs;
        }
    }
}
