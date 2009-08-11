using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 地址区域结构
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("area")]
    public class Area : BaseObject
    {
        /// <summary>
        /// 标准行政区域代码
        /// </summary>
        [JsonProperty("area_id")]
        [XmlElement("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 区域类型
        /// </summary>
        [JsonProperty("area_type")]
        [XmlElement("area_type")]
        public string AreaType { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        [JsonProperty("area_name")]
        [XmlElement("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 父节点区域标识
        /// </summary>
        [JsonProperty("parent_id")]
        [XmlElement("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// 具体一个地区的邮编
        /// </summary>
        [JsonProperty("zip")]
        [XmlElement("zip")]
        public string Zip { get; set; }
    }
}
