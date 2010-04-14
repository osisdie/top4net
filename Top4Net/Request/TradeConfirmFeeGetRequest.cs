using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.confirmfee.get
    /// </summary>
    public class TradeConfirmfeeGetRequest : ITopRequest
    {
        public string IsDetail { get; set; }
        public string Tid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.confirmfee.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("is_detail", this.IsDetail);
            parameters.Add("tid", this.Tid);
            return parameters;
        }

        #endregion
    }
}
