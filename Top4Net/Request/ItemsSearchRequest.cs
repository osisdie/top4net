using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.items.search
    /// </summary>
    public class ItemsSearchRequest : ITopRequest
    {
        /// <summary>
        /// 商品数据结构字段列表。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 搜索字段.q,cid,nicks,props,product_id中至少要一个。
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 卖家昵称列表,逗号分隔(目前最多支持5个卖家昵称，格式为nick1,nick2,nick3…). Q,cid,nicks,props,product_id中至少要一个。
        /// </summary>
        public string Nicks { get; set; }

        /// <summary>
        /// 商品所属类目Id. Q,cid,nicks,props,product_id中至少要一个。
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品最低价格. Q,cid,nicks,props,product_id中至少要一个。
        /// </summary>
        public string StartPrice { get; set; }

        /// <summary>
        /// 商品最高价格. Q,cid,nicks,props,product_id中至少要一个。
        /// </summary>
        public string EndPrice { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public string PageNo { get; set; }

        /// <summary>
        /// 每页条数。
        /// </summary>
        public string PageSize { get; set; }

        /// <summary>
        /// 排序方式.格式为column:asc/desc,column可选值为: price, delist_time, seller_credit.如price:asc表示按价格升序排列. 没有这个参数表示按默认排序方式。
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 商品属性.可以搜到拥有和输入属性一样的属性的商品的列表。
        /// </summary>
        public string PropList { get; set; }

        /// <summary>
        /// 可以根据产品Id搜索属于这个spu的商品。
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 旺旺在线状态（不设置结果包含所有状态，设置为true结果只有旺旺在线卖家的商品）不能单独使用，要和其他条件一起用才行。
        /// </summary>
        public string WwStatus { get; set; }

        /// <summary>
        /// 免运费（不设置包含所有邮费状态，设置为true结果只有卖家包邮的商品）不能单独使用，要和其他条件一起用才行。
        /// </summary>
        public string PostFree { get; set; }

        /// <summary>
        /// 所在省。
        /// </summary>
        public string LocationState { get; set; }

        /// <summary>
        /// 所在市。
        /// </summary>
        public string LocationCity { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.items.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("q", this.Query);
            parameters.Add("nicks", this.Nicks);
            parameters.Add("cid", this.CategoryId);
            parameters.Add("start_price", this.StartPrice);
            parameters.Add("end_price", this.EndPrice);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("props", this.PropList);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("ww_status", this.WwStatus);
            parameters.Add("post_free", this.PostFree);
            parameters.Add("location.state", this.LocationState);
            parameters.Add("location.city", this.LocationCity);

            return parameters;
        }

        #endregion
    }
}
