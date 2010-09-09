using System;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// CollectItem Data Structure.
    /// </summary>
    [Serializable]
    public class CollectItem : BaseObject
    {
        [XmlElement("item_numid")]
        public long ItemNumid { get; set; }
    }
}
