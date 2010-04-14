using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemcats.get
    /// </summary>
    public class ItemcatsGetRequest : ITopRequest
    {
        public string Cids { get; set; }
        public string Datetime { get; set; }
        public string Fields { get; set; }
        public Nullable<long> ParentCid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemcats.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cids", this.Cids);
            parameters.Add("datetime", this.Datetime);
            parameters.Add("fields", this.Fields);
            parameters.Add("parent_cid", this.ParentCid);
            return parameters;
        }

        #endregion
    }
}
