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
        /// 查询字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 是否查询推荐物流公司。
        /// </summary>
        public bool IsRecommended { get; set; }

        /// <summary>
        /// 推荐物流公司的下单方式
        /// </summary>
        public string OuterMode { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logisticcompanies.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("is_recommended", this.IsRecommended.ToString());
            parameters.Add("orderMode", this.OuterMode);

            return parameters;
        }

        #endregion
    }
}
