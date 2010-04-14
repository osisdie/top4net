using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.logistics.companies.get
    /// </summary>
    public class LogisticsCompaniesGetRequest : ITopRequest
    {
        public string Fields { get; set; }
        public Nullable<bool> IsRecommended { get; set; }
        public string OrderMode { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logistics.companies.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("is_recommended", this.IsRecommended);
            parameters.Add("order_mode", this.OrderMode);
            return parameters;
        }

        #endregion
    }
}
