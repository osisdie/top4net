using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 用户列表的XML响应解释器。
    /// </summary>
    public class UserListXmlParser : ITopParser<List<User>>
    {
        #region ITopParser<List<User>> Members

        public List<User> Parse(string body)
        {
            // 重写User类型的XML标签名称
            XmlAttributes attrs = new XmlAttributes();
            attrs.XmlElements.Add(new XmlElementAttribute("user", typeof(User)));

            // 重写UserListResponse类型里面的Users属性的标签名称
            XmlAttributeOverrides attrOvrs = new XmlAttributeOverrides();
            attrOvrs.Add(typeof(UserListResponse), "Users", attrs);

            XmlSerializer serializer = new XmlSerializer(typeof(UserListResponse), attrOvrs);

            object obj = serializer.Deserialize(new StringReader(body));
            UserListResponse ulr = obj as UserListResponse;
            return ulr == null ? null : ulr.Users;
        }

        #endregion

        /// <summary>
        /// 用户列表响应，用于XML反序列化。
        /// </summary>
        [Serializable]
        [XmlRoot("rsp")]
        public class UserListResponse
        {
            public List<User> Users { get; set; }
        }

    }
}
