using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.tp.subsc.add
    /// </summary>
    public class TpSubscAddRequest : ITopRequest<TpSubscAddResponse>
    {
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 订单结束时间
        /// </summary>
        public Nullable<DateTime> OrderEndTime { get; set; }

        /// <summary>
        /// 订单开始时间,此时间必须大于等于当前时间
        /// </summary>
        public Nullable<DateTime> OrderStartTime { get; set; }

        /// <summary>
        /// 外部交易订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.tp.subsc.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("nick", this.Nick);
            parameters.Add("order_end_time", this.OrderEndTime);
            parameters.Add("order_start_time", this.OrderStartTime);
            parameters.Add("out_trade_no", this.OutTradeNo);
            return parameters;
        }

        #endregion
    }
}
