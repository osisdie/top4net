using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 商品查询分类结果
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("itemCategory")]
    public class ItemCategory
    {
        /// <summary>
        /// 分类名称
        /// </summary>
        [JsonProperty( "category_name" )]
        [XmlElement( "category_name" )]
        public string CategoryName { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonProperty( "category_id" )]
        [XmlElement( "category_id" )]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty( "count" )]
        [XmlElement( "count" )]
        public string Count { get; set; }

        /// <summary>
        /// 分类地址
        /// </summary>
        [JsonProperty( "url" )]
        [XmlElement( "url" )]
        public string Url { get; set; }
    }
}
