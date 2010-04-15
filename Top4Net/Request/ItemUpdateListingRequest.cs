using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.update.listing
    /// </summary>
    public class ItemUpdateListingRequest : ITopRequest
    {
        public string Iid { get; set; }
        public Nullable<int> Num { get; set; }
        public Nullable<long> NumIid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.update.listing";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("iid", this.Iid);
            parameters.Add("num", this.Num);
            parameters.Add("num_iid", this.NumIid);
            return parameters;
        }

        #endregion
    }
}
