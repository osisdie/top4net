using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 产品信息。
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("product")]
    public class Product : BaseObject
    {
        /// <summary>
        /// 产品编号。
        /// </summary>
        [JsonProperty("product_id")]
        [XmlElement("product_id")]
        public string Id { get; set; }
        /// <summary>
        /// 产品名称。
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部产品编号。
        /// </summary>
        [JsonProperty("outer_id")]
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 标准产品编号。
        /// </summary>
        [JsonProperty("tsc")]
        [XmlElement("tsc")]
        public string StandardId { get; set; }

        /// <summary>
        /// 商品类目编号。
        /// </summary>
        [JsonProperty("cid")]
        [XmlElement("cid")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品类目名称。
        /// </summary>
        [JsonProperty("cat_name")]
        [XmlElement("cat_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 产品的关键属性列表。
        /// </summary>
        [JsonProperty("props")]
        [XmlElement("props")]
        public string PropList { get; set; }

        /// <summary>
        /// 产品的关键属性字符串列表。
        /// </summary>
        [JsonProperty("props_str")]
        [XmlElement("props_str")]
        public string PropStrList { get; set; }

        /// <summary>
        /// 产品的非关键（绑定）属性列表。
        /// </summary>
        [JsonProperty("binds")]
        [XmlElement("binds")]
        public string BindPropList { get; set; }

        /// <summary>
        /// 产品的非关键（绑定）字符串列表。
        /// </summary>
        [JsonProperty("binds_str")]
        [XmlElement("binds_str")]
        public string BindPropStrList { get; set; }

        /// <summary>
        /// 产品的销售属性列表。
        /// </summary>
        [JsonProperty("sale_props")]
        [XmlElement("sale_props")]
        public string SalePropList { get; set; }

        /// <summary>
        /// 产品的销售属性字符串列表。
        /// </summary>
        [JsonProperty("sale_props_str")]
        [XmlElement("sale_props_str")]
        public string SalePropStrList { get; set; }

        /// <summary>
        /// 产品的市场价。
        /// </summary>
        [JsonProperty("price")]
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 产品的描述。
        /// </summary>
        [JsonProperty("desc")]
        [XmlElement("desc")]
        public string Description { get; set; }

        /// <summary>
        /// 产品的主图片地址。
        /// </summary>
        [JsonProperty("pic_path")]
        [XmlElement("pic_path")]
        public string MainPicUrl { get; set; }

        /// <summary>
        /// 产品的创建时间。
        /// </summary>
        [JsonProperty("created")]
        [XmlIgnore]
        public DateTime Created { get; set; }

        [XmlElement("created")]
        public string CreatedStr
        {
            get { return Created.ToString(DATE_TIME_FORMAT); }
            set { Created = DateTime.ParseExact(value, DATE_TIME_FORMAT, null); }
        }

        /// <summary>
        /// 产品的修改时间。
        /// </summary>
        [JsonProperty("modified")]
        [XmlIgnore]
        public DateTime Modified { get; set; }

        [XmlElement("modified")]
        public string ModifiedStr
        {
            get { return Modified.ToString(DATE_TIME_FORMAT); }
            set { Modified = DateTime.ParseExact(value, DATE_TIME_FORMAT, null); }
        }

        /// <summary>
        /// 产品的子图片。
        /// </summary>
        public List<ProductImg> ProductImgList { get; set; }

        /// <summary>
        /// 产品的属性图片。
        /// </summary>
        public List<ProductPropImg> ProductPropImgList { get; set; }
    }
}
