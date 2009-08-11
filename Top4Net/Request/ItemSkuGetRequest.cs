using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.sku.get
    /// </summary>
    public class ItemSkuGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的字段。
        /// </summary>
        public string SkuId { get; set; }

        /// <summary>
        /// Sku的编号。
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// Sku所属用户的昵称。
        /// </summary>
        public string Fields { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.sku.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("sku_id", this.SkuId);
            parameters.Add("nick", this.Nick);
            parameters.Add("fields", this.Fields);

            return parameters;
        }

        #endregion
    }
}
