using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.skus.get
    /// </summary>
    public class ItemSkusGetRequest : ITopRequest
    {
        public string Fields { get; set; }
        public string Iids { get; set; }
        public string NumIids { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.skus.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("iids", this.Iids);
            parameters.Add("num_iids", this.NumIids);
            return parameters;
        }

        #endregion
    }
}
