using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.shop.remainshowcase.get
    /// </summary>
    public class ShopRemainshowcaseGetRequest : ITopRequest
    {
        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.shop.remainshowcase.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            return parameters;
        }

        #endregion
    }
}
