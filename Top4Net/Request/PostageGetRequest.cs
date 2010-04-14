using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.postage.get
    /// </summary>
    public class PostageGetRequest : ITopRequest
    {
        public string Fields { get; set; }
        public string Nick { get; set; }
        public Nullable<long> PostageId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.postage.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("nick", this.Nick);
            parameters.Add("postage_id", this.PostageId);
            return parameters;
        }

        #endregion
    }
}
