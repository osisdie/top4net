using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// TOP响应列表。
    /// </summary>
    /// <typeparam name="T">任何一种可序列化的领域对象</typeparam>
    [Serializable]
    [XmlRoot("rsp")]
    public class ResponseList<T>
    {
        /// <summary>
        /// 所有记录数。一般情况下比Content.Count大。
        /// </summary>
        [JsonProperty("totalResults")]
        [XmlElement("totalResults")]
        public long TotalResults { get; set; }

        public List<T> Content { get; set; }

        /// <summary>
        /// 根据指定的名字重写列表标签的名字。
        /// </summary>
        /// <param name="element">标签名字</param>
        /// <returns>重写逻辑</returns>
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
