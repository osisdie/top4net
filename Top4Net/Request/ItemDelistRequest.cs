using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.update.delisting
    /// </summary>
    public class ItemDelistRequest : ITopRequest
    {
        /// <summary>
        /// 需要下架的商品编号。
        /// </summary>
        public string Iid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.update.delisting";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("iid", this.Iid);

            return parameters;
        }

        #endregion
    }
}
