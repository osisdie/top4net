using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.user.detail.get
    /// </summary>
    public class UserDetailGetRequest : ITopRequest
    {
        public string AlipayNo { get; set; }
        public string Fields { get; set; }
        public string Nick { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.user.detail.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("alipay_no", this.AlipayNo);
            parameters.Add("fields", this.Fields);
            parameters.Add("nick", this.Nick);
            return parameters;
        }

        #endregion
    }
}
