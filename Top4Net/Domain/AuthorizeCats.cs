using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 地址区域结构
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("authorize")]
    public class AuthorizeCats : BaseObject
    {
        /// <summary>
        /// 品牌列表
        /// </summary>
        [JsonProperty("brands")]
        [XmlArray("brands")]
        [XmlArrayItem("brand")]
        public List<Brand> BrandList { get; set; }

        /// <summary>
        /// 类目列表
        /// </summary>
        [JsonProperty("item_cats")]
        [XmlArray("item_cats")]
        [XmlArrayItem("item_cat")]
        public List<ItemCat> ItemCatList { get; set; }
    }
}
