using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sellercats.list.update
    /// </summary>
    public class SellercatsListUpdateRequest : ITopRequest
    {
        public string Cid { get; set; }
        public string Name { get; set; }
        public string PictUrl { get; set; }
        public string SortOrder { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sellercats.list.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("name", this.Name);
            parameters.Add("pict_url", this.PictUrl);
            parameters.Add("sort_order", this.SortOrder);
            return parameters;
        }

        #endregion
    }
}
