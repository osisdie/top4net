using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// sku
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot( "sku" )]
    public class Sku
    {
        /// <summary>
        /// Ssku的id
        /// </summary>
        [JsonProperty( "sku_id" )]
        [XmlElement( "sku_id" )]
        public string SkuId { get; set; }

        /// <summary>
        /// Ssku所属商品id
        /// </summary>
        [JsonProperty( "iid" )]
        [XmlElement( "iid" )]
        public string Iid { get; set; }

        /// <summary>
        /// Ssku的销售属性组合字符串（颜色，大小，等等，可通过类目API获取某类目下的销售属性）,格式是p1:v1
        /// </summary>
        [JsonProperty( "properties" )]
        [XmlElement( "properties" )]
        public string Properties { get; set; }

        /// <summary>
        /// S属于这个sku的商品的数量
        /// </summary>
        [JsonProperty( "quantity" )]
        [XmlElement( "quantity" )]
        public int Quantity { get; set; }

        /// <summary>
        /// S属于这个sku的商品的价格 取值范围:0-100000000
        /// </summary>
        [JsonProperty( "price" )]
        [XmlElement( "price" )]
        public string Price { get; set; }

        /// <summary>
        /// S商家设置的外部id
        /// </summary>
        [JsonProperty( "outer_id" )]
        [XmlElement( "outer_id" )]
        public string OuterId { get; set; }

        /// <summary>
        /// Ssku创建日期 时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty( "created" )]
        [XmlElement( "created" )]
        public string Created { get; set; }

        /// <summary>
        /// Ssku最后修改日期 时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty( "modified" )]
        [XmlElement( "modified" )]
        public string Modified { get; set; }

        /// <summary>
        /// Ssku状态。 normal:正常delete:删除
        /// </summary>
        [JsonProperty( "status" )]
        [XmlElement( "status" )]
        public string Status { get; set; }


    }
}
