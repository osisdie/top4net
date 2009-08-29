using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.memo.update
    /// </summary>
    public class TradeMemoUpdateRequest : ITopRequest
    {
        /// <summary>
        /// 交易编号。
        /// </summary>
        public string Tid { get; set; }

        /// <summary>
        /// 交易备注。
        /// </summary>
        public string Memo { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.memo.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("memo", this.Memo);
            parameters.Add("tid", this.Tid);

            return parameters;
        }

        #endregion
    }
}
