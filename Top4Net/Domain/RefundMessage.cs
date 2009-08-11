using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 留言/凭证数据结构
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("refundMessage")]
    class RefundMessage : BaseObject
    {
        /// <summary>
        /// 留言编号
        /// </summary>
        [JsonProperty("message_id")]
        [XmlElement("message_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 留言内容
        /// </summary>
        [JsonProperty("content")]
        [XmlElement("content")]
        public string MsgContent { get; set; }

        /// <summary>
        /// 退款编号
        /// </summary>
        [JsonProperty("refund_id")]
        [XmlElement("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 留言者编号
        /// </summary>
        [JsonProperty("owner_id")]
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 留言者昵称
        /// </summary>
        [JsonProperty("owner_nick")]
        [XmlElement("owner_nick")]
        public string OwnerNick { get; set; }

        /// <summary>
        /// 留言者身份
        /// </summary>
        [JsonProperty("owner_role")]
        [XmlElement("owner_role")]
        public string OwnerRole { get; set; }

        /// <summary>
        /// 凭证附件地址（图片）
        /// </summary>
        [JsonProperty("picture_urls")]
        [XmlElement("picture_urls")]
        public string PicUrls { get; set; }
    }
}
