using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.products.search
    /// </summary>
    public class ProductsSearchRequest : ITopRequest
    {
        /// <summary>
        /// 要返回的产品字段列表。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 搜索的关键词。
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 类目编号。
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 关键属性串。
        /// </summary>
        public string Props { get; set; }

        /// <summary>
        /// 每页显示条数。
        /// </summary>
        public Nullable<int> PageNo { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public Nullable<int> PageSize { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.products.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("fields", this.Fields);
            parameters.Add("q", this.Query);
            parameters.Add("cid", this.Cid);
            parameters.Add("props", this.Props);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);

            return parameters;
        }

        #endregion
    }
}
