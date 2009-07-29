using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// 获取单个产品信息。
    /// </summary>
    public class ProductGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的字段列表，以逗号分隔。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 产品编号。
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 类目编号。
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// 关键属性列表。
        /// </summary>
        public string PropList { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", Fields);
            parameters.Add("product_id", ProductId);
            parameters.Add("cid", CategoryId);
            parameters.Add("props", PropList);

            return parameters;
        }

        #endregion
    }
}
