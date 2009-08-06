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
    public class TradeConfirmFee
    {
        /// <summary>
        /// 确认收货的金额(不包含邮费)。精确到2位小数
        /// </summary>
        [JsonProperty("confirm_fee")]
        [XmlElement("confirm_fee")]
        public string ConfirmFee { get; set; }

        /// <summary>
        /// 需确认收货的邮费，当不是最后一笔收货或者没有邮费时是0.00。精确到2位小数
        /// </summary>
        [JsonProperty("confirm_post_fee")]
        [XmlElement("confirm_post_fee")]
        public string ConfirmPostFee { get; set; }

        /// <summary>
        /// 是否是最后一笔订单（只对子订单有效，当其他子订单都是交易完成时，返回true，否则false）
        /// </summary>
        [JsonProperty("is_last_detail_order")]
        [XmlElement("is_last_detail_order")]
        public bool IsLastDetailOrder { get; set; }
    }
}
