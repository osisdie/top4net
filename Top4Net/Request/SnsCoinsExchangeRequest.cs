using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sns.coins.consume
    /// </summary>
    public class SnsCoinsExchangeRequest : ITopRequest
    {
        /// <summary>
        /// 兑换淘金币数。
        /// </summary>
        public Nullable<long> CoinCount { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sns.coins.consume";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("coin_count", this.CoinCount);

            return parameters;
        }

        #endregion
    }
}
