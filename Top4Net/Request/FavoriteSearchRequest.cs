using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.favorite.search
    /// </summary>
    public class FavoriteSearchRequest : ITopRequest
    {
        public Nullable<int> CollectType { get; set; }
        public Nullable<int> PageNo { get; set; }
        public string UserNick { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.favorite.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("collect_type", this.CollectType);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("user_nick", this.UserNick);
            return parameters;
        }

        #endregion
    }
}
