using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TpSubscAddResponse.
    /// </summary>
    public class TpSubscAddResponse : TopResponse
    {
        /// <summary>
        /// TP用户订购返回信息
        /// </summary>
        [XmlElement("tp_user_subsc")]
        public TpUserSubsc TpUserSubsc { get; set; }
    }
}
