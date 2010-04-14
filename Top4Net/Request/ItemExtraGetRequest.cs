using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemextra.get
    /// </summary>
    public class ItemextraGetRequest : ITopRequest
    {
        public string Fields { get; set; }
        public string Iid { get; set; }
        public string Nick { get; set; }
        public Nullable<long> NumIid { get; set; }
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemextra.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("iid", this.Iid);
            parameters.Add("nick", this.Nick);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("type", this.Type);
            return parameters;
        }

        #endregion
    }
}
