using System;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 用户的XML响应解释器。
    /// </summary>
    public class UserXmlParser : ITopParser<User>
    {
        #region ITopParser<User> Members

        public User Parse(string body)
        {
            UserListXmlParser parser = new UserListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 用户列表的XML响应解释器。
    /// </summary>
    public class UserListXmlParser : ITopParser<ResponseList<User>>
    {
        #region ITopParser<ResponseList<User>> Members

        public ResponseList<User> Parse(string body)
        {
            return ResponseList<User>.ParseXmlResponse("user", body);
        }

        #endregion
    }
}