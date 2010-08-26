using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.items.detail.get
    /// </summary>
    public class TaobaokeItemsDetailGetRequest : ITopRequest
    {
        public string Fields { get; set; }
        public string Nick { get; set; }
        public string NumIids { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.items.detail.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("nick", this.Nick);
            parameters.Add("num_iids", this.NumIids);
            return parameters;
        }

        #endregion
    }
}
