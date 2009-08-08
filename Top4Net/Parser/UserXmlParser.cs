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
            TopResponse<User> topRsp = new TopResponse<User>("user");
            XmlSerializer serializer = new XmlSerializer(typeof(TopResponse<User>), topRsp.GetOverrides());

            object obj = serializer.Deserialize(new StringReader(body));
            TopResponse<User> rsp = obj as TopResponse<User>;
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
            TopListResponse<User> topRsp = new TopListResponse<User>("user");
            XmlSerializer serializer = new XmlSerializer(typeof(TopListResponse<User>), topRsp.GetOverrides());

            object obj = serializer.Deserialize(new StringReader(body));
            TopListResponse<User> rsp = obj as TopListResponse<User>;
            return rsp == null ? null : rsp.Content;
        }

        #endregion
    }
}