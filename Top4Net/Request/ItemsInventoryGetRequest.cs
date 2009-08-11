using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.items.instock.get
    /// </summary>
    public class ItemsInventoryGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的商品对象字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 搜索字段。
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 分类字段。
        /// </summary>
        public string Banner { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public int PageNo { get; set; }

        /// <summary>
        /// 每页条数。
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 排序方式。
        /// </summary>
        public string OrderBy { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.items.instock.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("q", this.Query);
            parameters.Add("banner", this.Banner);
            parameters.Add("page_no", this.PageNo + "");
            parameters.Add("page_size", this.PageSize + "");
            parameters.Add("order_by", this.OrderBy);

            return parameters;
        }

        #endregion
    }
}
