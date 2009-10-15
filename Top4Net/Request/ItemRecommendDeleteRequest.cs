using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.recommend.delete
    /// </summary>
    public class ItemRecommendDeleteRequest : ITopRequest
    {
        /// <summary>
        /// 需要取消橱窗推荐的商品编号。
        /// </summary>
        public string Iid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.recommend.delete";
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
