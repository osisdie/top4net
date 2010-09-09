using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.favorite.add
    /// </summary>
    public class FavoriteAddRequest : ITopRequest
    {
        public Nullable<int> CollectType { get; set; }
        public Nullable<long> ItemNumid { get; set; }
        public Nullable<bool> Shared { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.favorite.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("collect_type", this.CollectType);
            parameters.Add("item_numid", this.ItemNumid);
            parameters.Add("shared", this.Shared);
            return parameters;
        }

        #endregion
    }
}
