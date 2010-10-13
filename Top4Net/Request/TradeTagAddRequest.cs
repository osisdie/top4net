using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.tag.add
    /// </summary>
    public class TradeTagAddRequest : ITopRequest
    {
        public string CertSign { get; set; }
        public string TagKeys { get; set; }
        public string TagValues { get; set; }
        public string Tids { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.tag.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cert_sign", this.CertSign);
            parameters.Add("tag_keys", this.TagKeys);
            parameters.Add("tag_values", this.TagValues);
            parameters.Add("tids", this.Tids);
            return parameters;
        }

        #endregion
    }
}
