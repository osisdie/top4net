using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// 获取多个用户信息。
    /// </summary>
    public class UsersGetRequest : ITopRequest
    {
        /// <summary>
        /// 返回字段列表，以逗号分隔。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 查询用户昵称列表，以逗号分隔。
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

            parameters.Add("fields", Fields);
            parameters.Add("nicks", Nicks);

            return parameters;
        }

        #endregion
    }
}
