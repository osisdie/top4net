using System;
using System.Collections.Generic;

using Taobao.Top.Api;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.items.get
    /// </summary>
    public class ItemsGetRequest : ITopRequest
    {
        /// <summary>
        /// 商品数据结构字段列表。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 搜索字段。
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 卖家昵称列表。
        /// </summary>
        public string Nicks { get; set; }

        /// <summary>
        /// 商品所属类目编号。
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 商品最低价格。
        /// </summary>
        public string StartPrice { get; set; }

        /// <summary>
        /// 商品最高价格。
        /// </summary>
        public string EndPrice { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public Nullable<int> PageNo { get; set; }

        /// <summary>
        /// 每页条数。
        /// </summary>
        public Nullable<int> PageSize { get; set; }

        /// <summary>
        /// 排序方式。
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 商品属性。
        /// </summary>
        public string Props { get; set; }

        /// <summary>
        /// 可以根据产品编号搜索属于这个SPU的商品。
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 旺旺在线状态。
        /// </summary>
        public string WwStatus { get; set; }

        /// <summary>
        /// 免运费。
        /// </summary>
        public string PostFree { get; set; }

        /// <summary>
        /// 所有地。
        /// </summary>
        public Location Location { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.items.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("fields", this.Fields);
            parameters.Add("q", this.Query);
            parameters.Add("nicks", this.Nicks);
            parameters.Add("cid", this.Cid);
            parameters.Add("start_price", this.StartPrice);
            parameters.Add("end_price", this.EndPrice);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("props", this.Props);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("ww_status", this.WwStatus);
            parameters.Add("post_free", this.PostFree);

            if (this.Location != null)
            {
                parameters.Add("location.state", this.Location.State);
                parameters.Add("location.city", this.Location.City);
            }

            return parameters;
        }

        #endregion
    }
}
