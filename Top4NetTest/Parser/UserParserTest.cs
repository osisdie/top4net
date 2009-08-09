using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test
{
    [TestClass]
    public class UserParserTest
    {
        [TestMethod]
        public void ParseJsonAsUser()
        {
            UserJsonParser parser = new UserJsonParser();
            string body = TestUtils.GetResourceAsText("user.json");
            User user = parser.Parse(body);
            AssertUser(user);
        }

        [TestMethod]
        public void ParseXmlAsUser()
        {
            UserXmlParser parser = new UserXmlParser();
            string body = TestUtils.GetResourceAsText("user.xml");
            User user = parser.Parse(body);
            AssertUser(user);
        }

        [TestMethod]
        public void ParseJsonAsUserList()
        {
            UserListJsonParser parser = new UserListJsonParser();
            string body = TestUtils.GetResourceAsText("users.json");
            List<User> users = parser.Parse(body).Content;
            Assert.AreEqual(2, users.Count);
            AssertUser(users[0]);
        }

        [TestMethod]
        public void ParseXmlAsUserList()
        {
            UserListXmlParser parser = new UserListXmlParser();
            string body = TestUtils.GetResourceAsText("users.xml");
            List<User> users = parser.Parse(body).Content;
            Assert.AreEqual(2, users.Count);
            AssertUser(users[0]);
        }

        private void AssertUser(User user)
        {
            Assert.AreEqual("65753281", user.UserId);
            Assert.AreEqual("tbtest520", user.Nick);
            Assert.AreEqual("m", user.Sex);
            Assert.AreEqual("2008-03-09 02:19:35", user.Created);
            Assert.AreEqual("浙江", user.Location.State);
            Assert.AreEqual("杭州", user.Location.City);
        }
    }
}
