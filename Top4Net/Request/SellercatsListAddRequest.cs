using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sellercats.list.add
    /// </summary>
    public class SellercatsListAddRequest : ITopRequest
    {
        public string Name { get; set; }
        public string ParentCid { get; set; }
        public string PictUrl { get; set; }
        public string SortOrder { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sellercats.list.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("name", this.Name);
            parameters.Add("parent_cid", this.ParentCid);
            parameters.Add("pict_url", this.PictUrl);
            parameters.Add("sort_order", this.SortOrder);
            return parameters;
        }

        #endregion
    }
}
