using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sns.friends.areFriends
    /// </summary>
    public class SnsFriendsCheckRequest : ITopRequest
    {
        /// <summary>
        /// 用户编号1。
        /// </summary>
        public string Uid1 { get; set; }

        /// <summary>
        /// 用户编号2。
        /// </summary>
        public string Uid2 { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sns.friends.areFriends";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("uid1", this.Uid1);
            parameters.Add("uid2", this.Uid2);

            return parameters;
        }

        #endregion
    }
}
