using System;
using System.IO;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test
{
    [TestClass]
    public class UserApiParserTest
    {
        [TestMethod]
        public void ParseJsonAsUser()
        {
            UserGetJsonParser parser = new UserGetJsonParser();
            string body = TestUtils.readResource("taobao.user.get.json");
            User user = parser.Parse(body);
            AssertResult(user);
        }

        [TestMethod]
        public void ParseXmlAsUser()
        {
            UserGetXmlParser parser = new UserGetXmlParser();
            string body = TestUtils.readResource("taobao.user.get.xml");
            User user = parser.Parse(body);
            AssertResult(user);
        }

        private void AssertResult(User user)
        {
            Assert.AreEqual("65753281", user.UserId);
            Assert.AreEqual("tbtest520", user.Nick);
            Assert.AreEqual("m", user.Sex);
            Assert.AreEqual("2008-03-09 02:19:35", user.Created.ToString(User.DATE_TIME_FORMAT));
            Assert.AreEqual("浙江", user.Location.State);
            Assert.AreEqual("杭州", user.Location.City);
        }
    }
}
