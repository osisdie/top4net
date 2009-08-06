using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 店铺内卖家自定义类目
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot( "sellerCat" )]
    public class SellerCat
    {
        /// <summary>
        /// 卖家自定义类目ID。
        /// </summary>
        [JsonProperty( "cid" )]
        [XmlElement( "cid" )]
        public string Cid { get; set; }
        /// <summary>
        /// 父类目cid，值等于0：表示此类目为店铺下的一级类目，值不等于0：表示此类目有父类目
        /// </summary>
        [JsonProperty( "parent_cid" )]
        [XmlElement( "parent_cid" )]
        public string ParentCid { get; set; }
        /// <summary>
        /// 卖家自定义类目名称。
        /// </summary>
        [JsonProperty( "name" )]
        [XmlElement( "name" )]
        public string Name { get; set; }
        /// <summary>
        /// 链接图片地址。
        /// </summary>
        [JsonProperty( "pict_url" )]
        [XmlElement( "pict_url" )]
        public string PictUrl { get; set; }
        /// <summary>
        /// 该类目在页面上的排序位置。
        /// </summary>
        [JsonProperty( "sort_order" )]
        [XmlElement( "sort_order" )]
        public int SortOrder { get; set; }
    }
}