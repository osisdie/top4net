using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.close
    /// </summary>
    public class TradeCloseRequest : ITopRequest
    {
        /// <summary>
        /// 交易编号。
        /// </summary>
        public string Tid { get; set; }

        /// <summary>
        /// 关闭原因。
        /// </summary>
        public string Reason { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.close";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("tid", this.Tid);
            parameters.Add("close_reason", this.Reason);

            return parameters;
        }

        #endregion
    }
}
