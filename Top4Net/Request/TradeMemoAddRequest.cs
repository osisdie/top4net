using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.memo.add
    /// </summary>
    public class TradeMemoAddRequest : ITopRequest
    {
        /// <summary>
        /// 备注内容。
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 交易ID。
        /// </summary>
        public string Tid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.memo.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("memo", this.Memo);
            parameters.Add("tid", this.Tid);

            return parameters;
        }

        #endregion
    }
}
