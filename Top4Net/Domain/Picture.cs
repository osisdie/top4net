using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 图片
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("picture")]
    public class Picture : BaseObject
    {
        /// <summary>
        /// 图片编号
        /// </summary>
        [JsonProperty("picture_id")]
        [XmlElement("picture_id")]
        public long Id { get; set; }

        /// <summary>
        /// 图片分类编号
        /// </summary>
        [JsonProperty("picture_category_id")]
        [XmlElement("picture_category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [JsonProperty("picture_path")]
        [XmlElement("picture_path")]
        public string Url { get; set; }

        /// <summary>
        /// 图片大小
        /// </summary>
        [JsonProperty("sizes")]
        [XmlElement("sizes")]
        public int Size { get; set; }

        /// <summary>
        /// 图片像素
        /// </summary>
        [JsonProperty("pixel")]
        [XmlElement("pixel")]
        public string Pixel { get; set; }

        /// <summary>
        /// 图片状态
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 图片是否已经被删除
        /// </summary>
        [JsonProperty("deleted")]
        [XmlElement("deleted")]
        public string Deleted { get; set; }
    }
}
