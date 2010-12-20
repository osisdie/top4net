using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// KoubeiUserGetResponse.
    /// </summary>
    public class KoubeiUserGetResponse : TopResponse
    {
        /// <summary>
        /// 符合条件的用户信息对象
        /// </summary>
        [XmlElement("kb_user_info")]
        public KbUserInfo KbUserInfo { get; set; }
    }
}
