using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemextra.get
    /// </summary>
    public class ItemExtraGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的商品对象字段，商品结构体中所有字段均可返回。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 昵称。
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 商品编号。
        /// </summary>
        public string Iid { get; set; }

        /// <summary>
        /// 扩展类型。
        /// </summary>
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemextra.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("fields", this.Fields);
            parameters.Add("nick", this.Nick);
            parameters.Add("iid", this.Iid);
            parameters.Add("type", this.Type);

            return parameters;
        }

        #endregion
    }
}
