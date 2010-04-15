using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itempropvalues.get
    /// </summary>
    public class ItempropvaluesGetRequest : ITopRequest
    {
        public Nullable<long> Cid { get; set; }
        public Nullable<DateTime> Datetime { get; set; }
        public string Fields { get; set; }
        public string Pvs { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itempropvalues.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("datetime", this.Datetime);
            parameters.Add("fields", this.Fields);
            parameters.Add("pvs", this.Pvs);
            return parameters;
        }

        #endregion
    }
}
