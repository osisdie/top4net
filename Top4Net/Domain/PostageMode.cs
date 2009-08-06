using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 运费方式模板收费方式
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot( "postageMode" )]
    class PostageMode
    {
        /// <summary>
        /// 运费模板ID
        /// </summary>
        [JsonProperty( "postage_id" )]
        [XmlElement( "postage_id" )]
        public string PostageId { get; set; }

        /// <summary>
        /// 运费方式项id
        /// </summary>
        [JsonProperty( "postage_mode_id" )]
        [XmlElement( "postage_mode_id" )]
        public string PostageModeId { get; set; }

        /// <summary>
        /// 运费方式(目前提供):平邮(post),快递公司(express),EMS(ems)
        /// </summary>
        [JsonProperty( "postage_mode.type" )]
        [XmlElement( "postage_mode.type" )]
        public string PostageMode.type { get; set; }

        /// <summary>
        /// 邮费子项涉及的地区,多个地区用逗号连接数量串
        /// </summary>
        [JsonProperty( "dest" )]
        [XmlElement( "dest" )]
        public string Dest { get; set; }

        /// <summary>
        /// 运费单价
        /// </summary>
        [JsonProperty( "price" )]
        [XmlElement( "price" )]
        public string Price { get; set; }

        /// <summary>
        /// 运费增价
        /// </summary>
        [JsonProperty( "increase" )]
        [XmlElement( "increase" )]
        public string Increase { get; set; }


    }
}
