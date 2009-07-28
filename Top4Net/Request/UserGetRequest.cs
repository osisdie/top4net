using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// 获取单个用户信息。
    /// </summary>
    public class UserGetRequest : ITopRequest
    {
        /// <summary>
        /// 返回字段列表，以逗号分隔。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 查询用户昵称。
        /// </summary>
        public string Nick { get; set; }

        public string GetApiName()
        {
            return "taobao.user.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", Fields);
            parameters.Add("nick", Nick);

            return parameters;
        }
    }
}
