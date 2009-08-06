using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 店铺类目
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("shopCat")]
    public class ShopCategory
    {
        /// <summary>
        /// 类目ID。
        /// </summary>
        [JsonProperty("cid")]
        [XmlElement("cid")]
        public string Cid { get; set; }
        /// <summary>
        /// 注：此类目指前台类目，值等于0：表示此类目为一级类目，值不等于0：表示此类目有父类目
        /// </summary>
        [JsonProperty("parent_cid")]
        [XmlElement("parent_cid")]
        public string ParentCid { get; set; }
        /// <summary>
        /// 类目名称。
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }
        /// <summary>
        /// 该类目是否为父类目。即：该类目是否还有子类目。
        /// </summary>
        [JsonProperty("is_parent")]
        [XmlElement("is_parent")]
        public bool IsParent { get; set; }
    }
}