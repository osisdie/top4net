using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trades.sold.increment.get
    /// </summary>
    public class TradesSoldIncrementGetRequest : ITopRequest
    {
        /// <summary>
        /// 要返回的字段列表。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 交易状态。
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 交易类型。
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 查询修改时间开始。
        /// </summary>
        public Nullable<DateTime> StartModified { get; set; }

        /// <summary>
        /// 查询修改时间结束。
        /// </summary>
        public Nullable<DateTime> EndModified { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public Nullable<int> PageNo { get; set; }

        /// <summary>
        /// 每页条数。
        /// </summary>
        public Nullable<int> PageSize { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trades.sold.increment.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("fields", this.Fields);
            parameters.Add("status", this.Status);
            parameters.Add("type", this.Type);
            parameters.Add("start_modified", this.StartModified);
            parameters.Add("end_modified", this.EndModified);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);

            return parameters;
        }

        #endregion
    }
}
