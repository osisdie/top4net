using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.items.convert
    /// </summary>
    public class TaobaokeItemsConvertRequest : ITopRequest
    {
        public string Fields { get; set; }
        public string Iids { get; set; }
        public string Nick { get; set; }
        public string NumIids { get; set; }
        public string OuterCode { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.items.convert";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("iids", this.Iids);
            parameters.Add("nick", this.Nick);
            parameters.Add("num_iids", this.NumIids);
            parameters.Add("outer_code", this.OuterCode);
            return parameters;
        }

        #endregion
    }
}
