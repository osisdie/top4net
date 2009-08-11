using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.traderates.get
    /// </summary>
    public class TradeRatesGetRequest : ITopRequest
    {
        /// <summary>
        /// 评价数据结构字段列表。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 评价状态。
        /// </summary>
        public string RateType { get; set; }

        /// <summary>
        /// 评价者加角色。
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// 评价结果。
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public int PageNo { get; set; }

        /// <summary>
        /// 每页条数。
        /// </summary>
        public int PageSize { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.traderates.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("rate_type", this.RateType);
            parameters.Add("role", this.Role);
            parameters.Add("result", this.Result);
            parameters.Add("page_no", this.PageNo + "");
            parameters.Add("page_size", this.PageSize + "");

            return parameters;
        }

        #endregion
    }
}
