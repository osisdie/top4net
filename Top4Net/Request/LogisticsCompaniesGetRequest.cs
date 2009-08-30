using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.logisticcompanies.get
    /// </summary>
    public class LogisticsCompaniesGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的字段列表。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 是否查询推荐物流公司。
        /// </summary>
        public Nullable<bool> IsRecommended { get; set; }

        /// <summary>
        /// 推荐物流公司的下单方式。
        /// </summary>
        public string OrderMode { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logisticcompanies.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("fields", this.Fields);
            parameters.Add("is_recommended", this.IsRecommended);
            parameters.Add("orderMode", this.OrderMode);

            return parameters;
        }

        #endregion
    }
}
