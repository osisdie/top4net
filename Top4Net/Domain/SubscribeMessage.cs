using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// SubscribeMessage Data Structure.
    /// </summary>
    [Serializable]
    public class SubscribeMessage : BaseObject
    {
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        [XmlElement("end_date")]
        public string EndDate { get; set; }

        [XmlElement("modified")]
        public string Modified { get; set; }

        [XmlArray("notify_infos")]
        [XmlArrayItem("notify_info")]
        public List<NotifyInfo> NotifyInfos { get; set; }

        [XmlElement("notify_url")]
        public string NotifyUrl { get; set; }

        [XmlElement("start_date")]
        public string StartDate { get; set; }

        [XmlArray("subscriptions")]
        [XmlArrayItem("subscription")]
        public List<Subscription> Subscriptions { get; set; }

        [XmlElement("valid")]
        public bool Valid { get; set; }
    }
}
