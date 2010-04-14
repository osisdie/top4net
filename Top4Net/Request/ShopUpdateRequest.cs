using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.shop.update
    /// </summary>
    public class ShopUpdateRequest : ITopRequest
    {
        public string Bulletin { get; set; }
        public string Desc { get; set; }
        public string Title { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.shop.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("bulletin", this.Bulletin);
            parameters.Add("desc", this.Desc);
            parameters.Add("title", this.Title);
            return parameters;
        }

        #endregion
    }
}
