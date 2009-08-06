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
        /// Product数据结构字段列表，以半角逗号(,)分隔。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 用户昵称。
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public string PageNo { get; set; }

        /// <summary>
        /// 每页条数。
        /// </summary>
        public string PageSize { get; set; }

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
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);

            return parameters;
        }

        #endregion
    }
}
