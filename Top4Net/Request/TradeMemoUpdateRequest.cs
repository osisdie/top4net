using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.memo.update
    /// </summary>
    public class TradeMemoUpdateRequest : ITopRequest
    {
        public string Memo { get; set; }
        public Nullable<long> Tid { get; set; }

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
