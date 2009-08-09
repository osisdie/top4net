using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 用户的JSON响应解释器。
    /// </summary>
    public class UserJsonParser : ITopParser<User>
    {
        #region ITopParser<User> Members

        public User Parse(string body)
        {
            UserListJsonParser parser = new UserListJsonParser();
            List<User> users = parser.Parse(body).Content;

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
    public class UserListJsonParser : ITopParser<ResponseList<User>>
    {
        #region ITopParser<ResponseList<User>> Members

        public ResponseList<User> Parse(string body)
        {
            ResponseList<User> rspList = new ResponseList<User>();

            JObject jsonBody = JObject.Parse(body);
            JArray jsonUsers = jsonBody["rsp"]["users"] as JArray;
            rspList.TotalResults = jsonBody["rsp"].Value<long>("totalResults");

            if (jsonUsers != null)
            {
                List<User> users = new List<User>();
                for (int i = 0; i < jsonUsers.Count; i++)
                {
                    JsonSerializer js = new JsonSerializer();
                    object user = js.Deserialize(jsonUsers[i].CreateReader(), typeof(User));
                    users.Add(user as User);
                }
                rspList.Content = users;
            }

            return rspList;
        }

        #endregion
    }
}
