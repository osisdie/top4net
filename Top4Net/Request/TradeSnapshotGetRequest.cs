using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.snapshot.get
    /// </summary>
    public class TradeSnapshotGetRequest : ITopRequest
    {
        /// <summary>
        /// 要返回的字段列表。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 交易编号。
        /// </summary>
        public string Tid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.snapshot.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("tid", this.Tid);
            return parameters;
        }

        #endregion
    }
}
