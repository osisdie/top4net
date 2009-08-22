using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.listurl.get
    /// </summary>
    public class TaobaokeListUrlGetRequest : ITopRequest
    {
        /// <summary>
        /// 关键词。
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 推广者的淘宝会员昵称。
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 用户自定义输入串。
        /// </summary>
        public string OuterCode { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.listurl.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("q", this.Query);
            parameters.Add("nick", this.Nick);
            parameters.Add("outerCode", this.OuterCode);

            return parameters;
        }

        #endregion
    }
}
