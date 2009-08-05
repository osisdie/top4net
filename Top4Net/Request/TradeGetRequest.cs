using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.get
    /// </summary>
    public class TradeGetRequest : ITopRequest
    {
        /// <summary>
        /// 交易ID。
        /// </summary>
        public string TradeId { get; set; }

        /// <summary>
        /// 需要返回的交易数据结构字段。
        /// </summary>
        public string Fields { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("tid", this.TradeId);
            parameters.Add("fields", this.Fields);

            return parameters;
        }

        #endregion
    }
}
