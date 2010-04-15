using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.propimg.delete
    /// </summary>
    public class ItemPropimgDeleteRequest : ITopRequest
    {
        public Nullable<long> Id { get; set; }
        public string Iid { get; set; }
        public Nullable<long> NumIid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.propimg.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("iid", this.Iid);
            parameters.Add("num_iid", this.NumIid);
            return parameters;
        }

        #endregion
    }
}
