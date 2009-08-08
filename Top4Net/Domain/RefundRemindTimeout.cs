using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 退款超时结构
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("refundRemindTimeout")]
    public class RefundRemindTimeout
    {
        /// <summary>
        /// 提醒的类型（退款详情中提示信息的类型）
        /// </summary>
        [JsonProperty("remind_type")]
        [XmlElement("remind_type")]
        public int RemindType { get; set; }

        /// <summary>
        /// 是否存在超时。可选值:true(是),false(否)
        /// </summary>
        [JsonProperty("exist_timeout")]
        [XmlElement("exist_timeout")]
        public bool IsTimeout { get; set; }

        /// <summary>
        /// 超时时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("timeout")]
        [XmlElement("timeout")]
        public string TimeoutTime { get; set; }
    }
}
