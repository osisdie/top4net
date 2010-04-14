using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.caturl.get
    /// </summary>
    public class TaobaokeCaturlGetRequest : ITopRequest
    {
        public string Cid { get; set; }
        public string Nick { get; set; }
        public string OuterCode { get; set; }
        public string Q { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.caturl.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("nick", this.Nick);
            parameters.Add("outer_code", this.OuterCode);
            parameters.Add("q", this.Q);
            return parameters;
        }

        #endregion
    }
}
