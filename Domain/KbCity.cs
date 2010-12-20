using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// KbCity Data Structure.
    /// </summary>
    [Serializable]
    public class KbCity : TopObject
    {
        /// <summary>
        /// 自增的字段
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 文本类型
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
