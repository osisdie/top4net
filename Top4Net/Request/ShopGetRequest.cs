using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.shop.get
    /// </summary>
    public class ShopGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的字段列表。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 卖家昵称。
        /// </summary>
        public string Nick { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.shop.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("fields", this.Fields);
            parameters.Add("nick", this.Nick);

            return parameters;
        }

        #endregion
    }
}
