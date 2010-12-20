using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.close
    /// </summary>
    public class TradeCloseRequest : ITopRequest<TradeCloseResponse>
    {
        /// <summary>
        /// 交易关闭原因。最小长度: 6个字节
        /// </summary>
        public string CloseReason { get; set; }

        /// <summary>
        /// 主订单编号（不支持关闭子订单）
        /// </summary>
        public Nullable<long> Tid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.close";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("close_reason", this.CloseReason);
            parameters.Add("tid", this.Tid);
            return parameters;
        }

        #endregion
    }
}
