using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// KoubeiCouponSearchResponse.
    /// </summary>
    public class KoubeiCouponSearchResponse : TopResponse
    {
        /// <summary>
        /// 返回KBListCoupon的List，其中包含List展示所需的对象列表
        /// </summary>
        [XmlArray("kb_list_coupons")]
        [XmlArrayItem("kb_list_coupon")]
        public List<KbListCoupon> KbListCoupons { get; set; }

        /// <summary>
        /// 查询结果总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
