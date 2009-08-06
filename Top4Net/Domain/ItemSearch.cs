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
    [XmlRoot("itemSearch")]
    public class ItemSearch
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        public List<Item> ItemList { get; set; }

        /// <summary>
        /// 商品搜索分类
        /// </summary>
        public List<ItemCategory> CategoryList { get; set; }
    }
}
