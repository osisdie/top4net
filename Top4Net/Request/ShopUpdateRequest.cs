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
        /// 店铺标题(title、bulletin和desc至少必须传一个)。
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
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("title", this.Title);
            parameters.Add("bulletin", this.Bulletin);
            parameters.Add("desc", this.Desc);

            return parameters;
        }

        #endregion
    }
}
