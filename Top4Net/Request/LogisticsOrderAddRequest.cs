using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.delivery.send
    /// </summary>
    public class LogisticsOrderAddRequest : ITopRequest
    {
        /// <summary>
        /// 交易编号。
        /// </summary>
        public string Tid { get; set; }

        /// <summary>
        /// 物流运单号。
        /// </summary>
        public string OutSid { get; set; }

        /// <summary>
        /// 调用者IP地址。
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 物流公司代码。
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// 卖家联系人姓名。
        /// </summary>
        public string SellerName { get; set; }

        /// <summary>
        /// 卖家区域县级行政区编号。
        /// </summary>
        public string SellerAreaId { get; set; }

        /// <summary>
        /// 卖家地址。
        /// </summary>
        public string SellerAddress { get; set; }

        /// <summary>
        /// 卖家邮编。
        /// </summary>
        public string SellerZip { get; set; }

        /// <summary>
        /// 卖家固定电话。
        /// </summary>
        public string SellerPhone { get; set; }

        /// <summary>
        /// 卖家手机号码。
        /// </summary>
        public string SellerMobile { get; set; }

        /// <summary>
        /// 卖家备注。
        /// </summary>
        public string SellerMemo { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.delivery.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("tid", this.Tid);
            parameters.Add("out_sid", this.OutSid);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("company_code", this.CompanyCode);
            parameters.Add("seller_name", this.SellerName);
            parameters.Add("seller_area_id", this.SellerAreaId);
            parameters.Add("seller_address", this.SellerAddress);
            parameters.Add("seller_zip", this.SellerZip);
            parameters.Add("seller_phone", this.SellerPhone);
            parameters.Add("seller_mobile", this.SellerMobile);
            parameters.Add("memo", this.SellerMemo);

            return parameters;
        }

        #endregion
    }
}
