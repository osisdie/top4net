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
        /// Product 目前返回值(product_id,name,pic_patch,cid,props,price,modified)。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 搜索的关键词(q,cid和props必须至少传一个)。
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 类目ID。
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 属性、属性值的组合，格式：pid:vid;pid:vid。
        /// </summary>
        public string Props { get; set; }

        /// <summary>
        /// 每页显示条数。
        /// </summary>
        public string PageNo { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public string PageSize { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.products.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

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
