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
        /// 需要获取的店铺信息字段。
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
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("nick", this.Nick);

            return parameters;
        }

        #endregion
    }
}
