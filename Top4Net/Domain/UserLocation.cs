using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 用户地址信息。
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("location")]
    public class UserLocation
    {
        /// <summary>
        /// 邮政编码。
        /// </summary>
        [JsonProperty("zip")]
        [XmlElement("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// 详细地址。
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 所在国家。
        /// </summary>
        [JsonProperty("country")]
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 所在省份。
        /// </summary>
        [JsonProperty("state")]
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 所在城市。
        /// </summary>
        [JsonProperty("city")]
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 所在区/县。
        /// </summary>
        [JsonProperty("district")]
        [XmlElement("district")]
        public string District { get; set; }
    }
}
