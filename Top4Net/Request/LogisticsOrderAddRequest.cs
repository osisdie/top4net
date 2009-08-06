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
        /// 交易ID。
        /// </summary>
        public string Tid { get; set; }

        /// <summary>
        /// 调用者ip地址。
        /// </summary>
        public string AppIp { get; set; }

        /// <summary>
        /// 物流公司代码。
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// 运单号。
        /// </summary>
        public string ShippingId { get; set; }

        /// <summary>
        /// 卖家联系人姓名。
        /// </summary>
        public string SellerName { get; set; }

        /// <summary>
        /// 卖家区域县级行政区 ID。
        /// </summary>
        public string SellerAreaId { get; set; }

        /// <summary>
        /// 卖家地址(详细地址)如:XXX街道XXX门牌,省市区不需要提供。
        /// </summary>
        public string SellerAddress { get; set; }

        /// <summary>
        /// 卖家邮编。
        /// </summary>
        public string SellerZip { get; set; }

        /// <summary>
        /// 两者必须选一,卖家固定电话或者手机号码. 包含区号,电话,分机号,中间用“ – “分隔。
        /// </summary>
        public string SellerPhone { get; set; }

        /// <summary>
        /// 卖家手机号码。
        /// </summary>
        public string SellerMobile { get; set; }

        /// <summary>
        /// 卖家备注。
        /// </summary>
        public string Memo { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.delivery.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("tid", this.Tid);
            parameters.Add("app_ip", this.AppIp);
            parameters.Add("company_code", this.CompanyCode);
            parameters.Add("out_sid", this.ShippingId);
            parameters.Add("seller_name", this.SellerName);
            parameters.Add("seller_area_id", this.SellerAreaId);
            parameters.Add("seller_address", this.SellerAddress);
            parameters.Add("seller_zip", this.SellerZip);
            parameters.Add("seller_phone", this.SellerPhone);
            parameters.Add("seller_mobile", this.SellerMobile);
            parameters.Add("memo", this.Memo);

            return parameters;
        }

        #endregion
    }
}
