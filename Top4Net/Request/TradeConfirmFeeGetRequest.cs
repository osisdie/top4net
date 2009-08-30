using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.confirmfee.get
    /// </summary>
    public class TradeConfirmFeeGetRequest : ITopRequest
    {
        /// <summary>
        /// 交易编号。
        /// </summary>
        public string Tid { get; set; }

        /// <summary>
        /// 是否为子订单。
        /// </summary>
        public Nullable<bool> IsChildOrder { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.confirmfee.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("tid", this.Tid);

            if (IsChildOrder != null)
            {
                if (IsChildOrder.Value)
                {
                    parameters.Add("is_detail", "IS_CHILD");
                }
                else
                {
                    parameters.Add("is_detail", "IS_FATHER");
                }
            }


            return parameters;
        }

        #endregion
    }
}
