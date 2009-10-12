using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.suites.get
    /// </summary>
    public class SuitesGetRequest : ITopRequest
    {
        /// <summary>
        /// 用户订购服务的服务码。
        /// </summary>
        public string ServiceCode { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.suites.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("service_code", this.ServiceCode);
            return parameters;
        }

        #endregion
    }
}
