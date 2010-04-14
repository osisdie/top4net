using System;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// PicUrl Data Structure.
    /// </summary>
    [Serializable]
    public class PicUrl : BaseObject
    {
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
