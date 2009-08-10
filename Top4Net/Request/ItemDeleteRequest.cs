using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.delete
    /// </summary>
    public class ItemDeleteRequest : ITopRequest
    {
        /// <summary>
        /// 商品编号。
        /// </summary>
        public string Iid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("iid", this.Iid);

            return parameters;
        }

        #endregion
    }
}
