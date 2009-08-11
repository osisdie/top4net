using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 淘宝客报表
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("TaobaokeReport")]
    public class TaobaokeReport : BaseObject
    {
        /// <summary>
        /// 淘宝客报表成员列表
        /// </summary>
        [JsonProperty("members")]
        [XmlElement("members")]
        public List<TaobaokeReportMember> MemberList { get; set; }
    }
}
