using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.items.all.get
    /// </summary>
    public class ItemsAllGetRequest : ITopRequest
    {
        /// <summary>
        /// 要返回的商品字段列表。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 查询条件。
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 商品类目编号。
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 卖家自定义的商品类目编号列表。
        /// </summary>
        public string SellerCids { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public int PageNo { get; set; }

        /// <summary>
        /// 每页大小。
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 排序方式。
        /// </summary>
        public string OrderBy { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.items.all.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("q", this.Query);
            parameters.Add("cid", this.Cid);
            parameters.Add("seller_cids", this.SellerCids);
            parameters.Add("page_no", this.PageNo + "");
            parameters.Add("page_size", this.PageSize + "");
            parameters.Add("order_by", this.OrderBy);

            return parameters;
        }

        #endregion
    }
}
