using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 确认收货费用结构
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("confirmFee")]
    public class ConfirmFee : BaseObject
    {
        /// <summary>
        /// 确认收货的金额
        /// </summary>
        [JsonProperty("confirm_fee")]
        [XmlElement("confirm_fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 需确认收货的邮费
        /// </summary>
        [JsonProperty("confirm_post_fee")]
        [XmlElement("confirm_post_fee")]
        public string PostFee { get; set; }

        /// <summary>
        /// 是否是最后一笔订单
        /// </summary>
        [JsonProperty("is_last_detail_order")]
        [XmlElement("is_last_detail_order")]
        public bool IsLastOrder { get; set; }
    }
}
