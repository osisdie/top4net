using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.skus.custom.get
    /// </summary>
    public class SkusCustomGetRequest : ITopRequest
    {
        public string Fields { get; set; }
        public string OuterId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.skus.custom.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("outer_id", this.OuterId);
            return parameters;
        }

        #endregion
    }
}
