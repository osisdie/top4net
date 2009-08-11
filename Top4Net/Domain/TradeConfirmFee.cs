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
    [XmlRoot("tradeConfirmFee")]
    public class TradeConfirmFee : BaseObject
    {
        /// <summary>
        /// 确认收货的金额
        /// </summary>
        [JsonProperty("confirm_fee")]
        [XmlElement("confirm_fee")]
        public string ConfirmFee { get; set; }

        /// <summary>
        /// 需确认收货的邮费
        /// </summary>
        [JsonProperty("confirm_post_fee")]
        [XmlElement("confirm_post_fee")]
        public string ConfirmPostFee { get; set; }

        /// <summary>
        /// 是否是最后一笔订单
        /// </summary>
        [JsonProperty("is_last_detail_order")]
        [XmlElement("is_last_detail_order")]
        public bool IsLastDetailOrder { get; set; }
    }
}
