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
        /// 商品图片的编号
        /// </summary>
        [JsonProperty("itemimg_id")]
        [XmlElement("itemimg_id")]
        public string ImgId { get; set; }

        /// <summary>
        /// 商品图片链接地址
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 图片放在第几张（多图时可设置 )
        /// </summary>
        [JsonProperty("position")]
        [XmlElement("position")]
        public string Position { get; set; }
    }
}
