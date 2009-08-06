using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 属性图片
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot( "propImg" )]
    public class PropImg
    {
        /// <summary>
        /// 属性图片的id
        /// </summary>
        [JsonProperty( "propimg_id" )]
        [XmlElement( "propimg_id" )]
        public string PropimgId { get; set; }

        /// <summary>
        /// 图片链接地址
        /// </summary>
        [JsonProperty( "url" )]
        [XmlElement( "url" )]
        public string Url { get; set; }

        /// <summary>
        /// 图片所对应的属性组合的字符串
        /// </summary>
        [JsonProperty( "properties" )]
        [XmlElement( "properties" )]
        public string Properties { get; set; }

        /// <summary>
        /// 图片放在第几张（多图时可设置）
        /// </summary>
        [JsonProperty( "position" )]
        [XmlElement( "position" )]
        public string Position { get; set; }


    }
}
