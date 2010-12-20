using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TpUserSubsc Data Structure.
    /// </summary>
    [Serializable]
    public class TpUserSubsc : TopObject
    {
        /// <summary>
        /// 订购状况成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订购url链接
        /// </summary>
        [XmlElement("subsc_link")]
        public string SubscLink { get; set; }
    }
}
