using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 商品分类
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("itemCategory")]
    public class ItemCategory
    {
        /// <summary>
        /// 分类编号
        /// </summary>
        [JsonProperty("category_id")]
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [JsonProperty("category_name")]
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 分类地址
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string CategoryUrl { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("count")]
        [XmlElement("count")]
        public long ItemCount { get; set; }
    }
}
