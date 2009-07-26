using System;

using Taobao.Top.Api.Domain;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// TOP API: taobao.user.get的JSON响应解释器。
    /// </summary>
    public class UserGetJsonParser : ITopParser<User>
    {
        #region ITopParser<User> Members

        public User Parse(string body)
        {
            JObject jsonBody = JObject.Parse(body);
            JArray jsonUsers = jsonBody["rsp"]["users"] as JArray;
            JsonSerializer js = new JsonSerializer();
            object user = js.Deserialize(jsonUsers[0].CreateReader(), typeof(User));
            return user as User;
        }

        #endregion
    }
}
