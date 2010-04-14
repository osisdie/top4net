using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.suites.get
    /// </summary>
    public class SuitesGetRequest : ITopRequest
    {
        public string Fields { get; set; }
        public string ServiceCode { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.suites.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("service_code", this.ServiceCode);
            return parameters;
        }

        #endregion
    }
}
