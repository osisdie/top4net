using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// 获取多个产品信息。
    /// </summary>
    public class ProductsGetRequest : ITopRequest
    {
        /// <summary>
        ///  需要返回的字段列表，以逗号分隔。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 用户昵称。
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 返回每页记录数。
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 返回第几页的数据。
        /// </summary>
        public int PageNo { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.products.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", Fields);
            parameters.Add("nick", Nick);
            parameters.Add("page_size", PageSize + "");
            parameters.Add("page_no", PageNo + "");

            return parameters;
        }

        #endregion
    }
}
