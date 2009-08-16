using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.update.listing
    /// </summary>
    public class ItemEnlistRequest : ITopRequest
    {
        /// <summary>
        /// 需要上架的商品编号。
        /// </summary>
        public string Iid { get; set; }

        /// <summary>
        /// 需要上架的商品的数量。
        /// </summary>
        public int Num { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.update.listing";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("iid", this.Iid);
            parameters.Add("num", this.Num.ToString());

            return parameters;
        }

        #endregion
    }
}
