using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.increment.subscribemessage.get
    /// </summary>
    public class IncrementSubscribemessageGetRequest : ITopRequest
    {
        public string Fields { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.increment.subscribemessage.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            return parameters;
        }

        #endregion
    }
}
