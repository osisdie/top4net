using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 产品主属性
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("sku")]
    public class Sku
    {
        /// <summary>
        /// Sku的编号
        /// </summary>
        [JsonProperty("sku_id")]
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// Sku所属商品编号
        /// </summary>
        [JsonProperty("iid")]
        [XmlElement("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// Sku的销售属性组合字符串，格式是p1:v1;p2:v2
        /// </summary>
        [JsonProperty("properties")]
        [XmlElement("properties")]
        public string SkuProps { get; set; }

        /// <summary>
        /// 属于这个Sku的商品的数量
        /// </summary>
        [JsonProperty("quantity")]
        [XmlElement("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// 属于这个sku的商品的价格 取值范围:0-100000000
        /// </summary>
        [JsonProperty("price")]
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商家设置的外部编号
        /// </summary>
        [JsonProperty("outer_id")]
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// Sku创建日期，时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("created")]
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// Sku最后修改日期，时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("modified")]
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// Sku状态。 normal:正常delete:删除
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
