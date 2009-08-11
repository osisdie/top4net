using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.update.showcase
    /// </summary>
    public class ItemRecommendAddRequest : ITopRequest
    {
        /// <summary>
        /// 需要橱窗推荐的商品编号。
        /// </summary>
        public string Iid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.update.showcase";
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
