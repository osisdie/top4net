using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.memo.add
    /// </summary>
    public class TradeMemoAddRequest : ITopRequest
    {
        public string Memo { get; set; }
        public string Tid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.memo.add";
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
