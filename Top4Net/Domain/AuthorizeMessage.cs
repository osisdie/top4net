using System;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// AuthorizeMessage Data Structure.
    /// </summary>
    [Serializable]
    public class AuthorizeMessage : BaseObject
    {
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        [XmlElement("created")]
        public DateTime Created { get; set; }

        [XmlElement("end_date")]
        public string EndDate { get; set; }

        [XmlElement("modified")]
        public DateTime Modified { get; set; }

        [XmlElement("nick")]
        public string Nick { get; set; }

        [XmlElement("start_date")]
        public string StartDate { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }
    }
}
