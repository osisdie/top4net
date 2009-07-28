using System;
using System.Collections.Generic;
using System.Text;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// 搜索产品信息。
    /// </summary>
    public class ProductsSearchRequest : ITopRequest
    {
        /// <summary>
        /// 返回字段列表，以逗号分隔。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 搜索关键词。
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 商品类目编号。
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品属性值集合。
        /// </summary>
        public string PropList { get; set; }

        /// <summary>
        /// 返回每页记录数。
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 返回页码。
        /// </summary>
        public int PageNo { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.products.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", Fields);
            parameters.Add("q", Query);
            parameters.Add("cid", CategoryId);
            parameters.Add("props", PropList);
            parameters.Add("page_size", PageSize + "");
            parameters.Add("page_no", PageNo + "");

            return parameters;
        }

        #endregion
    }
}
