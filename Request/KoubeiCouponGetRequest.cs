using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.koubei.coupon.get
    /// </summary>
    public class KoubeiCouponGetRequest : ITopRequest<KoubeiCouponGetResponse>
    {
        /// <summary>
        /// 优惠券的id
        /// </summary>
        public string CouponId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.koubei.coupon.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("coupon_id", this.CouponId);
            return parameters;
        }

        #endregion
    }
}
