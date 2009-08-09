using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Newtonsoft.Json;


namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 商品属性
    /// </summary>
    public class ItemProp
    {
        /// <summary>
        /// 属性编号
        /// </summary>
        [JsonProperty("pid")]
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否关键属性
        /// </summary>
        [JsonProperty("is_key_prop")]
        [XmlElement("is_key_prop")]
        public bool IsKeyProp { get; set; }

        /// <summary>
        /// 是否销售属性
        /// </summary>
        [JsonProperty("is_sale_prop")]
        [XmlElement("is_sale_prop")]
        public bool IsSaleProp { get; set; }

        /// <summary>
        /// 是否颜色属性
        /// </summary>
        [JsonProperty("is_color_prop")]
        [XmlElement("is_color_prop")]
        public bool IsColorProp { get; set; }

        /// <summary>
        /// 是否是可枚举属性
        /// </summary>
        [JsonProperty("is_enum_prop")]
        [XmlElement("is_enum_prop")]
        public bool IsEnumProp { get; set; }

        /// <summary>
        /// 是否是卖家可以自行输入的属性
        /// </summary>
        [JsonProperty("is_input_prop")]
        [XmlElement("is_input_prop")]
        public string IsInputProp { get; set; }

        /// <summary>
        /// 是否商品属性
        /// </summary>
        [JsonProperty("is_item_prop")]
        [XmlElement("is_item_prop")]
        public string IsItemProp { get; set; }

        /// <summary>
        /// 子属性的模板
        /// </summary>
        [JsonProperty("child_template")]
        [XmlElement("child_template")]
        public string ChildPropTemplate { get; set; }

        /// <summary>
        /// 发布产品或商品时是否为必选属性
        /// </summary>
        [JsonProperty("must")]
        [XmlElement("must")]
        public bool IsMust { get; set; }

        /// <summary>
        /// 发布产品或商品时是否可以多选
        /// </summary>
        [JsonProperty("multi")]
        [XmlElement("multi")]
        public bool IsMulti { get; set; }

        /// <summary>
        /// 上级属性编号
        /// </summary>
        [JsonProperty("parent_pid")]
        [XmlElement("parent_pid")]
        public string ParentPid { get; set; }

        /// <summary>
        /// 上级属性值编号
        /// </summary>
        [JsonProperty("parent_vid")]
        [XmlElement("parent_vid")]
        public string ParentVid { get; set; }

        /// <summary>
        /// 属性值对象
        /// </summary>
        [JsonProperty("prop_values")]
        [XmlArray("prop_values")]
        [XmlArrayItem("prop_value")]
        public List<PropValue> PropValueList { get; set; }

        /// <summary>
        /// 属性状态。可选值:normal(正常),deleted(删除) 
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 排列序号
        /// </summary>
        [JsonProperty("sort_order")]
        [XmlElement("sort_order")]
        public int SortOrder { get; set; }
    }
}
