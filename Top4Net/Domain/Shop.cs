using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot( "shop" )]
    public class Shop
    {
        /// <summary>
        /// 店铺ID。
        /// </summary>
        [JsonProperty( "sid" )]
        [XmlElement( "sid" )]
        public string Sid { get; set; }
        /// <summary>
        /// 店铺所属的类目ID。
        /// </summary>
        [JsonProperty( "cid" )]
        [XmlElement( "cid" )]
        public string Cid { get; set; }
        /// <summary>
        /// 卖家昵称。
        /// </summary>
        [JsonProperty( "nick" )]
        [XmlElement( "nick" )]
        public string Nick { get; set; }
        /// <summary>
        /// 店铺标题。
        /// </summary>
        [JsonProperty( "title" )]
        [XmlElement( "title" )]
        public string Title { get; set; }
        /// <summary>
        /// 店铺描述。
        /// </summary>
        [JsonProperty( "desc" )]
        [XmlElement( "desc" )]
        public string Desc { get; set; }
        /// <summary>
        /// 店铺公告。
        /// </summary>
        [JsonProperty( "bulletin" )]
        [XmlElement( "bulletin" )]
        public string Bulletin { get; set; }
        /// <summary>
        /// 店标地址。返回相对路径，可以用"http://logo.taobao.com/shop-logo/"来拼接成绝对路径。
        /// </summary>
        [JsonProperty( "pic_path" )]
        [XmlElement( "pic_path" )]
        public string PicPath { get; set; }
        /// <summary>
        /// 开店时间。格式：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonProperty( "created" )]
        [XmlElement( "created" )]
        public DateTime Created { get; set; }
        /// <summary>
        /// 最后修改时间。格式：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonProperty( "modified" )]
        [XmlElement( "modified" )]
        public DateTime Modified { get; set; }
    }
}
