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
    class RefundMessage
    {
        /// <summary>
        /// 留言id
        /// </summary>
        [JsonProperty("message_id")]
        [XmlElement("message_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// 退款id。Refund数据结构的refund_id
        /// </summary>
        [JsonProperty("refund_id")]
        [XmlElement("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 留言者id
        /// </summary>
        [JsonProperty("owner_id")]
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 留言者nick
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
        /// 留言内容。最大长度: 400个字节
        /// </summary>
        [JsonProperty("content")]
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 凭证附件地址（图片）
        /// </summary>
        [JsonProperty("picture_urls")]
        [XmlElement("picture_urls")]
        public string PictureUrls { get; set; }

        /// <summary>
        /// 留言创建时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("created")]
        [XmlElement("created")]
        public DateTime Created { get; set; }
    }
}
