using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.shop.update
    /// </summary>
    public class ShopUpdateRequest : ITopRequest
    {
        /// <summary>
        /// 店铺标题。
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 店铺公告。
        /// </summary>
        public string Bulletin { get; set; }

        /// <summary>
        /// 店铺描述。
        /// </summary>
        public string Desc { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.shop.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("title", this.Title);
            parameters.Add("bulletin", this.Bulletin);
            parameters.Add("desc", this.Desc);

            return parameters;
        }

        #endregion
    }
}
