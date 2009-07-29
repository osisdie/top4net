using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 用户对象的JSON响应解释器。
    /// </summary>
    public class UserJsonParser : ITopParser<User>
    {
        #region ITopParser<User> Members

        public User Parse(string body)
        {
            ITopParser<List<User>> parser = new UserListJsonParser();
            List<User> users = parser.Parse(body);

            if (users != null && users.Count > 0)
            {
                return users[0];
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}
