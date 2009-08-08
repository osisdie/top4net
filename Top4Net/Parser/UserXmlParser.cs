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
            XmlSerializer serializer = new XmlSerializer(typeof(UserRsp));
            object obj = serializer.Deserialize(new StringReader(body));
            return (obj as UserRsp).User;
        }

        #endregion

        /// <summary>
        /// 用户响应类，用于XML反序列化。
        /// </summary>
        [Serializable]
        [XmlRoot("rsp")]
        public class UserRsp
        {
            [XmlElement("user")]
            public User User { get; set; }
        }
    }


    /// <summary>
    /// 用户列表的XML响应解释器。
    /// </summary>
    public class UserListXmlParser : ITopParser<List<User>>
    {
        #region ITopParser<List<User>> Members

        public List<User> Parse(string body)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UserListRsp));
            object obj = serializer.Deserialize(new StringReader(body));
            UserListRsp rsp = obj as UserListRsp;
            return rsp == null ? null : rsp.Users;
        }

        #endregion

        /// <summary>
        /// 用户列表响应，用于XML反序列化。
        /// </summary>
        [Serializable]
        [XmlRoot("rsp")]
        public class UserListRsp
        {
            [XmlElement("user")]
            public List<User> Users { get; set; }
        }

    }
}
