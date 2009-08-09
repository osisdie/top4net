using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 商品搜索
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("itemsearch")]
    public class ItemSearch
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [JsonProperty("item_list")]
        [XmlArray("item_lists")]
        [XmlArrayItem("item_list")]
        public List<Item> ItemList { get; set; }

        /// <summary>
        /// 商品分类列表
        /// </summary>
        [JsonProperty("category_list")]
        [XmlArray("category_lists")]
        [XmlArrayItem("category_list")]
        public List<ItemCategory> ItemCatList { get; set; }
    }
}
