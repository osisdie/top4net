using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// KoubeiCouponGetResponse.
    /// </summary>
    public class KoubeiCouponGetResponse : TopResponse
    {
        /// <summary>
        /// 返回KBDetailCoupon类型，其中包含展示detail必须的一些内容
        /// </summary>
        [XmlElement("kb_detail_coupon")]
        public KbDetailCoupon KbDetailCoupon { get; set; }
    }
}
