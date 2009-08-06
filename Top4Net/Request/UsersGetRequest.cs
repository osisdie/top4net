using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.users.get
    /// </summary>
    public class UsersGetRequest : ITopRequest
    {
        /// <summary>
        /// User数据结构字段列表，以半角逗号(,)分隔。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 用户昵称，多个用逗号分隔。
        /// </summary>
        public string Nicks { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.users.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("nicks", this.Nicks);

            return parameters;
        }

        #endregion
    }
}
