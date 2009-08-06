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
        /// 交易ID。
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
        /// 是否匿名（是:true;否:false;）。
        /// </summary>
        public string Anony { get; set; }

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
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("tid", this.Tid);
            parameters.Add("content", this.Content);
            parameters.Add("result", this.Result);
            parameters.Add("anony", this.Anony);
            parameters.Add("role", this.Role);

            return parameters;
        }

        #endregion
    }
}
