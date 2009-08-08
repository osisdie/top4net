using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

    /// <summary>
    /// 用户列表的JSON响应解释器。
    /// </summary>
    public class UserListJsonParser : ITopParser<List<User>>
    {
        #region ITopParser<List<User>> Members

        public List<User> Parse(string body)
        {
            List<User> users = new List<User>();

            JObject jsonBody = JObject.Parse(body);
            JArray jsonUsers = jsonBody["rsp"]["users"] as JArray;

            if (jsonUsers != null)
            {
                for (int i = 0; i < jsonUsers.Count; i++)
                {
                    JsonSerializer js = new JsonSerializer();
                    object user = js.Deserialize(jsonUsers[i].CreateReader(), typeof(User));
                    users.Add(user as User);
                }
            }

            return users;
        }

        #endregion
    }
}
