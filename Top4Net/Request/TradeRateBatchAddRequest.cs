using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.traderate.list.add
    /// </summary>
    public class TradeRateBatchAddRequest : ITopRequest
    {
        /// <summary>
        /// 交易编号。
        /// </summary>
        public string Tid { get; set; }

        /// <summary>
        /// 评价内容。
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 评价结果。
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 是否匿名。
        /// </summary>
        public Nullable<bool> Anonymous { get; set; }

        /// <summary>
        /// 评价角色。
        /// </summary>
        public string Role { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.traderate.list.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("tid", this.Tid);
            parameters.Add("content", this.Content);
            parameters.Add("result", this.Result);
            parameters.Add("anony", this.Anonymous);
            parameters.Add("role", this.Role);

            return parameters;
        }

        #endregion
    }
}
