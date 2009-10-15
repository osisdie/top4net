using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.recommend.add
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
            return "taobao.item.recommend.add";
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
