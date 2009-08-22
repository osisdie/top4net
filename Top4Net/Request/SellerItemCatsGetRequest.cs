using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sellercats.list.get
    /// </summary>
    public class SellerItemCatsGetRequest : ITopRequest
    {
        /// <summary>
        /// 卖家昵称。
        /// </summary>
        public string Nick { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sellercats.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("nick", this.Nick);

            return parameters;
        }

        #endregion
    }
}
