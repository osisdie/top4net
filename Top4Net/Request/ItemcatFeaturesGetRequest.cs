using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemcat.features.get
    /// </summary>
    public class ItemcatFeaturesGetRequest : ITopRequest
    {
        public string AttrKeys { get; set; }
        public Nullable<long> Cid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemcat.features.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("attr_keys", this.AttrKeys);
            parameters.Add("cid", this.Cid);
            return parameters;
        }

        #endregion
    }
}
