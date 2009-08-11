using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.fullinfo.get
    /// </summary>
    public class TradeDetailGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的交易数据结构字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 交易编号。
        /// </summary>
        public string Tid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.fullinfo.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("tid", this.Tid);

            return parameters;
        }

        #endregion
    }
}
