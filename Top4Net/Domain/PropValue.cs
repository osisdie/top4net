using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 属性值
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot( "propValue" )]
    class PropValue
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [JsonProperty( "cid" )]
        [XmlElement( "cid" )]
        public string Cid { get; set; }
        /// <summary>
        /// 属性ID
        /// </summary>
        [JsonProperty( "pid" )]
        [XmlElement( "pid" )]
        public string Pid { get; set; }
        /// <summary>
        /// 属性名
        /// </summary>
        [JsonProperty( "prop_name" )]
        [XmlElement( "prop_name" )]
        public string PropName { get; set; }
        /// <summary>
        /// 属性值ID
        /// </summary>
        [JsonProperty( "vid" )]
        [XmlElement( "vid" )]
        public string Vid { get; set; }
        /// <summary>
        /// 属性值
        /// </summary>
        [JsonProperty( "name" )]
        [XmlElement( "name" )]
        public string Name { get; set; }
        /// <summary>
        /// 属性值别名
        /// </summary>
        [JsonProperty( "name_alias" )]
        [XmlElement( "name_alias" )]
        public string NameAlias { get; set; }
        /// <summary>
        /// 是否为父类目属性
        /// </summary>
        [JsonProperty( "is_parent" )]
        [XmlElement( "is_parent" )]
        public bool IsParent { get; set; }
        /// <summary>
        /// 状态。可选值:normal(正常),deleted(删除)
        /// </summary>
        [JsonProperty( "status" )]
        [XmlElement( "status" )]
        public string Status { get; set; }
        /// <summary>
        /// 排列序号。取值范围:大于零的整数
        /// </summary>
        [JsonProperty( "sort_order" )]
        [XmlElement( "sort_order" )]
        public int SortOrder { get; set; }
    }
}
