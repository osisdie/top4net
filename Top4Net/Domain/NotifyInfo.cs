using System;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// NotifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NotifyInfo : BaseObject
    {
        [XmlElement("is_notify")]
        public string IsNotify { get; set; }

        [XmlElement("topic")]
        public string Topic { get; set; }
    }
}
