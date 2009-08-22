using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.shopcats.list.get
    /// </summary>
    public class ShopCatsGetRequest : ITopRequest
    {
        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.shopcats.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            return parameters;
        }

        #endregion
    }
}
