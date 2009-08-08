using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 相册
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("album")]
    public class Album
    {
        /// <summary>
        /// 相册编号
        /// </summary>
        [JsonProperty("id")]
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        [JsonProperty("uid")]
        [XmlElement("uid")]
        public long Uid { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("nick")]
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 相册名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 相册描述
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 封面地址
        /// </summary>
        [JsonProperty("cover_url")]
        [XmlElement("cover_url")]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 照片总数
        /// </summary>
        [JsonProperty("pic_count")]
        [XmlElement("pic_count")]
        public int PicCount { get; set; }
    }
}