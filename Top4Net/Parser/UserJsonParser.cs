using System;

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
            return parser.Parse(body).GetFirst();
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
            return ResponseList<User>.ParseJsonResponse("users", body);
        }

        #endregion
    }
}
