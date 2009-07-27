using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// TOP API: taobao.users.get的XML响应解释器。
    /// </summary>
    public class UserListXmlParser : ITopParser<List<User>>
    {
        #region ITopParser<List<User>> Members

        public List<User> Parse(string body)
        {
            XmlAttributes attrs = new XmlAttributes();
            attrs.XmlElements.Add(new XmlElementAttribute("user", typeof(User)));

            XmlAttributeOverrides attrOvrs = new XmlAttributeOverrides();
            attrOvrs.Add(typeof(UserListResponse), "Users", attrs);

            XmlSerializer serializer = new XmlSerializer(typeof(UserListResponse), attrOvrs);

            object obj = serializer.Deserialize(new StringReader(body));
            UserListResponse ulr = obj as UserListResponse;
            return ulr == null ? null : ulr.Users;
        }

        #endregion

        [Serializable]
        [XmlRoot("rsp")]
        public class UserListResponse
        {
            public List<User> Users { get; set; }
        }

    }
}
