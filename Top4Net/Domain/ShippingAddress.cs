using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 买家收货地址
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("shippingAddress")]
    public class ShippingAddress : BaseObject
    {
        /// <summary>
        /// 收货地址编号
        /// </summary>
        [JsonProperty("address_id")]
        [XmlElement("address_id")]
        public string AddressId { get; set; }

        /// <summary>
        /// 收货人地址信息
        /// </summary>
        [JsonProperty("location")]
        [XmlElement("location")]
        public Location Location { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [JsonProperty("receiver_name")]
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人固定电话号码
        /// </summary>
        [JsonProperty("phone")]
        [XmlElement("phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 收货人移动电话号码
        /// </summary>
        [JsonProperty("mobile")]
        [XmlElement("mobile")]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 是否作为默认收货地址
        /// </summary>
        [JsonProperty("is_default")]
        [XmlElement("is_default")]
        public bool IsDefault { get; set; }
    }
}
