using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// KoubeiCitySubsGetResponse.
    /// </summary>
    public class KoubeiCitySubsGetResponse : TopResponse
    {
        /// <summary>
        /// 子集城市
        /// </summary>
        [XmlArray("kb_cities")]
        [XmlArrayItem("kb_city")]
        public List<KbCity> KbCities { get; set; }
    }
}
