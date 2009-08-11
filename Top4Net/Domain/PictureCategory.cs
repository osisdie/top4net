using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 图片分类
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("pictureCategory")]
    public class PictureCategory : BaseObject
    {
        /// <summary>
        /// 图片分类编号
        /// </summary>
        [JsonProperty("picture_category_id")]
        [XmlElement("picture_category_id")]
        public long Id { get; set; }

        /// <summary>
        /// 图片分类名
        /// </summary>
        [JsonProperty("picture_category_name")]
        [XmlElement("picture_category_name")]
        public string Name { get; set; }

        /// <summary>
        /// 卖家编号
        /// </summary>
        [JsonProperty("uid")]
        [XmlElement("uid")]
        public long Uid { get; set; }

        /// <summary>
        /// 图片分类排序
        /// </summary>
        [JsonProperty("sorts")]
        [XmlElement("sorts")]
        public long Sort { get; set; }

        /// <summary>
        /// 图片分类型别
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public long Type { get; set; }

        /// <summary>
        /// 分类下的图片数
        /// </summary>
        [JsonProperty("total")]
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        [XmlElement("gmt_create")]
        public new string Created { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        [XmlElement("gmt_modified")]
        public new string Modified { get; set; }
    }
}
