using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.get
    /// </summary>
    public class ItemGetRequest : ITopRequest
    {
        public string Fields { get; set; }
        public string Iid { get; set; }
        public string Nick { get; set; }
        public Nullable<long> NumIid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("iid", this.Iid);
            parameters.Add("nick", this.Nick);
            parameters.Add("num_iid", this.NumIid);
            return parameters;
        }

        #endregion
    }
}
