using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.update.delisting
    /// </summary>
    public class ItemUpdateDelistingRequest : ITopRequest
    {
        public string Iid { get; set; }
        public Nullable<long> NumIid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.update.delisting";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("iid", this.Iid);
            parameters.Add("num_iid", this.NumIid);
            return parameters;
        }

        #endregion
    }
}
