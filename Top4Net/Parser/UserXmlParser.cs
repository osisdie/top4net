using System;
using System.Xml.Serialization;

using Taobao.Top.Api.Domain;
using System.IO;
using System.Collections.Generic;

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
    /// 用户列表的XML响应解释器。
    /// </summary>
    public class UserListXmlParser : ITopParser<ResponseList<User>>
    {
        #region ITopParser<ResponseList<User>> Members

        public ResponseList<User> Parse(string body)
        {
            XmlAttributeOverrides attrs = ResponseList<User>.GetOverrides("user");
            XmlSerializer serializer = new XmlSerializer(typeof(ResponseList<User>), attrs);

            object obj = serializer.Deserialize(new StringReader(body));
            return obj as ResponseList<User>;
        }

        #endregion
    }
}