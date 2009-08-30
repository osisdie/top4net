using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.shipping.addresses.get
    /// </summary>
    public class DeliveryAddressesGetRequest : ITopRequest
    {
        /// <summary>
        /// 要返回的字段列表。
        /// </summary>
        public string Fields { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.shipping.addresses.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            return parameters;
        }

        #endregion
    }
}
