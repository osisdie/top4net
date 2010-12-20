using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// KoubeiCityTocityResponse.
    /// </summary>
    public class KoubeiCityTocityResponse : TopResponse
    {
        /// <summary>
        /// 转换成口碑的城市对象
        /// </summary>
        [XmlElement("kb_city")]
        public KbCity KbCity { get; set; }
    }
}
