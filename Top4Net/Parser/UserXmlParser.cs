using System;
using System.Xml.Serialization;

using Taobao.Top.Api.Domain;
using System.IO;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// TOP API: taobao.user.get的XML响应解释器。
    /// </summary>
    public class UserXmlParser : ITopParser<User>
    {
        #region ITopParser<User> Members

        public User Parse(string body)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UserResponse));
            object obj = serializer.Deserialize(new StringReader(body));
            return (obj as UserResponse).User;
        }

        #endregion

        /// <summary>
        /// 用户响应类，用于XML反序列化。
        /// </summary>
        [Serializable]
        [XmlRoot("rsp")]
        public class UserResponse
        {
            [XmlElement("user")]
            public User User { get; set; }
        }
    }
}
