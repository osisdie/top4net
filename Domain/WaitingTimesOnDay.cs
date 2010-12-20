using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// WaitingTimesOnDay Data Structure.
    /// </summary>
    [Serializable]
    public class WaitingTimesOnDay : TopObject
    {
        /// <summary>
        /// 等待时长（统计）日期
        /// </summary>
        [XmlElement("waiting_date")]
        public string WaitingDate { get; set; }

        /// <summary>
        /// 等待时长列表
        /// </summary>
        [XmlArray("waiting_time_list")]
        [XmlArrayItem("waiting_times")]
        public List<WaitingTimes> WaitingTimeList { get; set; }
    }
}
