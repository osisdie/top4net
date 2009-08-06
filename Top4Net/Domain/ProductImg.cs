using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 产品图片。
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("product_img")]
    public class ProductImg
    {
        /// <summary>
        /// 产品图片编号。
        /// </summary>
        [JsonProperty("pic_id")]
        [XmlElement("pic_id")]
        public string ImgId { get; set; }

        /// <summary>
        /// 产品图片绝对地址。
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 产品图片序号。
        /// </summary>
        [JsonProperty("position")]
        [XmlElement("position")]
        public int Position { get; set; }

        /// <summary>
        /// 图片所属产品的编号。
        /// </summary>
        [JsonProperty("product_id")]
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品图片的创建时间。
        /// </summary>
        [JsonProperty("created")]
        [XmlIgnore]
        public DateTime Created { get; set; }

        [XmlElement("created")]
        public string CreatedStr
        {
            get { return Created.ToString(Constants.DATE_TIME_FORMAT); }
            set { Created = DateTime.ParseExact(value, Constants.DATE_TIME_FORMAT, null); }
        }

        /// <summary>
        /// 产品图片的修改时间。
        /// </summary>
        [JsonProperty("modified")]
        [XmlIgnore]
        public DateTime Modified { get; set; }

        [XmlElement("modified")]
        public string ModifiedStr
        {
            get { return Modified.ToString(Constants.DATE_TIME_FORMAT); }
            set { Modified = DateTime.ParseExact(value, Constants.DATE_TIME_FORMAT, null); }
        }
    }
}
