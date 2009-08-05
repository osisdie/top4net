using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sns.friends.get
    /// </summary>
    public class SnsFriendsGetRequest : ITopRequest
    {
        /// <summary>
        /// 用户id。
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// 开始条数。
        /// </summary>
        public string StartRow { get; set; }

        /// <summary>
        /// 总条数。
        /// </summary>
        public string Count { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sns.friends.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("uid", this.Uid);
            parameters.Add("start_row", this.StartRow);
            parameters.Add("count", this.Count);

            return parameters;
        }

        #endregion
    }
}
