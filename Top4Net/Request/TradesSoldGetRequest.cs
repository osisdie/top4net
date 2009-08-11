using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trades.sold.get
    /// </summary>
    public class TradesSoldGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的交易数据结构字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 查询交易创建时间开始。
        /// </summary>
        public string StartCreated { get; set; }

        /// <summary>
        /// 查询交易创建时间结束。
        /// </summary>
        public string EndCreated { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public int PageNo { get; set; }

        /// <summary>
        /// 每页条数。
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 商品名称。
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 交易状态。
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 买家昵称。
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 查询修改时间开始。
        /// </summary>
        public string StartModified { get; set; }

        /// <summary>
        /// 查询修改时间结束。
        /// </summary>
        public string EndModified { get; set; }

        /// <summary>
        /// 交易类型。
        /// </summary>
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trades.sold.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("start_created", this.StartCreated);
            parameters.Add("end_created", this.EndCreated);
            parameters.Add("page_no", this.PageNo + "");
            parameters.Add("page_size", this.PageSize + "");
            parameters.Add("title", this.Title);
            parameters.Add("status", this.Status);
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("start_modified", this.StartModified);
            parameters.Add("end_modified", this.EndModified);
            parameters.Add("type", this.Type);

            return parameters;
        }

        #endregion
    }
}
