using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.products.get
    /// </summary>
    public class ProductsGetRequest : ITopRequest
    {
        /// <summary>
        /// 要返回的产品字段列表。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 用户昵称。
        /// </summary>
        public string Nick { get; set; }

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
            return "taobao.products.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("nick", this.Nick);
            parameters.Add("page_no", this.PageNo + "");
            parameters.Add("page_size", this.PageSize + "");

            return parameters;
        }

        #endregion
    }
}
