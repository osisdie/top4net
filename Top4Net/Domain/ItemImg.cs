using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 商品图片
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("itemImg")]
    public class ItemImg
    {
        /// <summary>
        /// S商品图片的id
        /// </summary>
        [JsonProperty( "itemimg_id" )]
        [XmlElement( "itemimg_id" )]
        public string ItemimgId { get; set; }

        /// <summary>
        /// S图片链接地址
        /// </summary>
        [JsonProperty( "url" )]
        [XmlElement( "url" )]
        public string Url { get; set; }

        /// <summary>
        /// S图片放在第几张（多图时可设置 )
        /// </summary>
        [JsonProperty( "position" )]
        [XmlElement( "position" )]
        public string Position { get; set; }
    }
}
