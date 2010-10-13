using System;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// TradeResult Data Structure.
    /// </summary>
    [Serializable]
    public class TradeResult : BaseObject
    {
        [XmlElement("sub_code")]
        public string SubCode { get; set; }

        [XmlElement("sub_msg")]
        public string SubMsg { get; set; }

        [XmlElement("trade")]
        public Trade Trade { get; set; }
    }
}
