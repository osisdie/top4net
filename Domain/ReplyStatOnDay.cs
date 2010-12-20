using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// ReplyStatOnDay Data Structure.
    /// </summary>
    [Serializable]
    public class ReplyStatOnDay : TopObject
    {
        /// <summary>
        /// 某天（的回复统计）
        /// </summary>
        [XmlElement("reply_date")]
        public string ReplyDate { get; set; }

        /// <summary>
        /// 客服回复统计
        /// </summary>
        [XmlArray("reply_stat_list")]
        [XmlArrayItem("reply_statistics")]
        public List<ReplyStatistics> ReplyStatList { get; set; }
    }
}
