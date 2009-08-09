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
            XmlAttributeOverrides attrs = Response<User>.GetOverrides("user");
            XmlSerializer serializer = new XmlSerializer(typeof(Response<User>), attrs);

            object obj = serializer.Deserialize(new StringReader(body));
            Response<User> rsp = obj as Response<User>;
            return rsp == null ? null : rsp.Content;
        }

        #endregion
    }

    /// <summary>
    /// 用户列表的XML响应解释器。
    /// </summary>
    public class UserListXmlParser : ITopParser<List<User>>
    {
        #region ITopParser<List<User>> Members

        public List<User> Parse(string body)
        {
            XmlAttributeOverrides attrs = ResponseList<User>.GetOverrides("user");
            XmlSerializer serializer = new XmlSerializer(typeof(ResponseList<User>), attrs);

            object obj = serializer.Deserialize(new StringReader(body));
            ResponseList<User> rsp = obj as ResponseList<User>;
            return rsp == null ? null : rsp.Content;
        }

        #endregion
    }
}