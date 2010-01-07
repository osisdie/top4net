using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.shippingaddress.update
    /// </summary>
    public class TradeShippingAddressUpdateRequest : ITopRequest
    {
        /// <summary>
        /// 交易编号。
        /// </summary>
        public Nullable<long> Tid { get; set; }

        /// <summary>
        /// 收货人全名。
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// 固定电话。
        /// </summary>
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 移动电话。
        /// </summary>
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 省份。
        /// </summary>
        public string ReceiverState { get; set; }

        /// <summary>
        /// 城市。
        /// </summary>
        public string ReceiverCity { get; set; }

        /// <summary>
        /// 区/县。
        /// </summary>
        public string ReceiverDistrict { get; set; }

        /// <summary>
        /// 收货地址。
        /// </summary>
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 邮政编码。
        /// </summary>
        public string ReceiverZip { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.shippingaddress.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("tid", this);
            parameters.Add("receiver_name", this);
            parameters.Add("receiver_phone", this);
            parameters.Add("receiver_mobile", this);
            parameters.Add("receiver_state", this);
            parameters.Add("receiver_city", this);
            parameters.Add("receiver_district", this);
            parameters.Add("receiver_address", this);
            parameters.Add("receiver_zip", this);
            return parameters;
        }

        #endregion
    }
}
