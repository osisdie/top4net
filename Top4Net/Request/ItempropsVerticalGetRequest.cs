using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemprops.vertical.get
    /// </summary>
    public class ItempropsVerticalGetRequest : ITopRequest
    {
        public Nullable<long> Cid { get; set; }
        public string Fields { get; set; }
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemprops.vertical.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("fields", this.Fields);
            parameters.Add("type", this.Type);
            return parameters;
        }

        #endregion
    }
}
