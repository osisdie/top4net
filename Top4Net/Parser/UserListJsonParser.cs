using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// TOP API: taobao.users.get的JSON响应解释器。
    /// </summary>
    public class UserListJsonParser : ITopParser<List<User>>
    {
        #region ITopParser<List<User>> Members

        public List<User> Parse(string body)
        {
            List<User> users = new List<User>();

            JObject jsonBody = JObject.Parse(body);
            JArray jsonUsers = jsonBody["rsp"]["users"] as JArray;

            for (int i = 0; i < jsonUsers.Count; i++)
            {
                JsonSerializer js = new JsonSerializer();
                object user = js.Deserialize(jsonUsers[i].CreateReader(), typeof(User));
                users.Add(user as User);
            }

            return users;
        }

        #endregion
    }
}
