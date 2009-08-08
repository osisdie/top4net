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
    public class Picture
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
        /// 图片大小,byte单位
        /// </summary>
        [JsonProperty("sizes")]
        [XmlElement("sizes")]
        public int Size { get; set; }

        /// <summary>
        /// 图片像素,格式:长X宽,如640x480
        /// </summary>
        [JsonProperty("pixel")]
        [XmlElement("pixel")]
        public string Pixel { get; set; }

        /// <summary>
        /// 图片状态,normal代表没有被冻结,froze代表被冻结,pass代表排查通过
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// deleted代表删除,undeleted未删除
        /// </summary>
        [JsonProperty("deleted")]
        [XmlElement("deleted")]
        public string Deleted { get; set; }

        /// <summary>
        /// 上传时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("created")]
        [XmlElement("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// 修改时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("modified")]
        [XmlElement("modified")]
        public DateTime Modified { get; set; }
    }
}
