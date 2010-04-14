using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.listurl.get
    /// </summary>
    public class TaobaokeListurlGetRequest : ITopRequest
    {
        public string Nick { get; set; }
        public string OuterCode { get; set; }
        public string Q { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.listurl.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("nick", this.Nick);
            parameters.Add("outer_code", this.OuterCode);
            parameters.Add("q", this.Q);
            return parameters;
        }

        #endregion
    }
}
