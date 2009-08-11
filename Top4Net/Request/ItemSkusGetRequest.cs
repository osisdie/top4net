using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.skus.get
    /// </summary>
    public class ItemSkusGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 商品的编号列表。
        /// </summary>
        public string Iids { get; set; }

        /// <summary>
        /// 商品所属卖家昵称。
        /// </summary>
        public string Nick { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.skus.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("iids", this.Iids);
            parameters.Add("nick", this.Nick);

            return parameters;
        }

        #endregion
    }
}
