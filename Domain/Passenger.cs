using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Passenger Data Structure.
    /// </summary>
    [Serializable]
    public class Passenger : TopObject
    {
        /// <summary>
        /// 乘机人姓名
        /// </summary>
        [XmlElement("passenger_name")]
        public string PassengerName { get; set; }

        /// <summary>
        /// 乘机人联系电话
        /// </summary>
        [XmlElement("passenger_phone")]
        public string PassengerPhone { get; set; }

        /// <summary>
        /// PNR信息
        /// </summary>
        [XmlElement("pnr")]
        public string Pnr { get; set; }

        /// <summary>
        /// 票号
        /// </summary>
        [XmlElement("ticket_no")]
        public string TicketNo { get; set; }
    }
}
