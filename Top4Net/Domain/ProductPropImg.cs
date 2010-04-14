using System;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// ProductPropImg Data Structure.
    /// </summary>
    [Serializable]
    public class ProductPropImg : BaseObject
    {
        [XmlElement("created")]
        public DateTime Created { get; set; }

        [XmlElement("id")]
        public long Id { get; set; }

        [XmlElement("modified")]
        public DateTime Modified { get; set; }

        [XmlElement("position")]
        public int Position { get; set; }

        [XmlElement("product_id")]
        public long ProductId { get; set; }

        [XmlElement("props")]
        public string Props { get; set; }

        [XmlElement("url")]
        public string Url { get; set; }
    }
}
