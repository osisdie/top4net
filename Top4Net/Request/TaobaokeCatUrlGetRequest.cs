using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.caturl.get
    /// </summary>
    public class TaobaokeCatUrlGetRequest : ITopRequest
    {
        /// <summary>
        /// 关键词。
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 类目编号。
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 推广者的淘宝会员昵称。
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 自定义输入串。
        /// </summary>
        public string OuterCode { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.caturl.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("q", this.Query);
            parameters.Add("cid", this.Cid);
            parameters.Add("nick", this.Nick);
            parameters.Add("outer_code", this.OuterCode);
            return parameters;
        }

        #endregion
    }
}
