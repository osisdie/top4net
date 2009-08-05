using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.items.onsale.get
    /// </summary>
    public class ItemsOnsaleGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的商品对象字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 搜索字段.模糊查询。
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 类目ID。
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// 卖家店铺内自定义类目ID(格式:id1,id2,…)。
        /// </summary>
        public string SellerCids { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public string PageNo { get; set; }

        /// <summary>
        /// 每页条数。
        /// </summary>
        public string PageSize { get; set; }

        /// <summary>
        /// 是否参与会员折扣。
        /// </summary>
        public string HasDiscount { get; set; }

        /// <summary>
        /// 是否橱窗推荐。
        /// </summary>
        public string HasShowcase { get; set; }

        /// <summary>
        /// 排序方式. 格式为column:asc/desc。（list_time,delist_time, num）。
        /// </summary>
        public string OrderBy { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.items.onsale.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("q", this.Query);
            parameters.Add("cid", this.CategoryId);
            parameters.Add("seller_cids", this.SellerCids);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("has_discount", this.HasDiscount);
            parameters.Add("has_showcase", this.HasShowcase);
            parameters.Add("order_by", this.OrderBy);

            return parameters;
        }

        #endregion
    }
}
