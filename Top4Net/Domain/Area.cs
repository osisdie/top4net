using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 地址区域结构
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot( "area" )]
    public class Area
    {
        /// <summary>
        /// 标准行政区域代码.参考:http://www.stats.gov.cn/tjbz/xzqhdm/t20080215_402462675.htm.
        /// </summary>
        [JsonProperty( "area_id" )]
        [XmlElement( "area_id" )]
        public string AreaId { get; set; }

        /// <summary>
        /// 区域类型.area区域 1:country/国家
        /// </summary>
        [JsonProperty( "area_type" )]
        [XmlElement( "area_type" )]
        public string AreaType { get; set; }

        /// <summary>
        /// 地域名称.如北京市,杭州市,西湖区,每一个area_id 都代表了一个具体的地区.
        /// </summary>
        [JsonProperty( "area_name" )]
        [XmlElement( "area_name" )]
        public string AreaName { get; set; }

        /// <summary>
        /// 父节点区域标识.如北京市的area_id是110100,朝阳区是北京市的一个区,所以朝阳区的parent_id就是北京市的area_id.
        /// </summary>
        [JsonProperty( "parent_id" )]
        [XmlElement( "parent_id" )]
        public string ParentId { get; set; }

        /// <summary>
        /// 具体一个地区的邮编
        /// </summary>
        [JsonProperty( "zip" )]
        [XmlElement( "zip" )]
        public string Zip { get; set; }


    }
}
