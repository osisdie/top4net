using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// KoubeiStoreGetResponse.
    /// </summary>
    public class KoubeiStoreGetResponse : TopResponse
    {
        /// <summary>
        /// 店铺detail信息，无则返回null
        /// </summary>
        [XmlElement("kb_detail_store")]
        public KbDetailStore KbDetailStore { get; set; }
    }
}
