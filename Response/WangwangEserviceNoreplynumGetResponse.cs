using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangEserviceNoreplynumGetResponse.
    /// </summary>
    public class WangwangEserviceNoreplynumGetResponse : TopResponse
    {
        /// <summary>
        /// 未回复统计列表
        /// </summary>
        [XmlArray("non_reply_stat")]
        [XmlArrayItem("non_reply_stat_on_day")]
        public List<NonReplyStatOnDay> NonReplyStat { get; set; }
    }
}
