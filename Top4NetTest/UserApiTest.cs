using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test
{
    [TestClass]
    public class UserApiTest
    {
        [TestMethod]
        public void GetUserByJson()
        {
            GetUser("json", new UserJsonParser());
        }

        [TestMethod]
        public void GetUserByXml()
        {
            GetUser("xml", new UserXmlParser());
        }

        [TestMethod]
        public void GetUsersByJson()
        {
            GetUsers("json", new UserListJsonParser());
        }

        [TestMethod]
        public void GetUsersByXml()
        {
            GetUsers("xml", new UserListXmlParser());
        }

        private void GetUser(string format, ITopParser<User> parser)
        {
            ITopClient client = TestUtils.GetTestTopClient(format);
            UserGetRequest request = new UserGetRequest();
            request.Fields = "user_id,nick,sex,created,location";
            request.Nick = "tbtest520";

            User user = client.Execute(request, parser);
            AssertUser(user);
        }

        private void GetUsers(string format, ITopParser<List<User>> parser)
        {
            ITopClient client = TestUtils.GetTestTopClient(format);
            UsersGetRequest request = new UsersGetRequest();
            request.Fields = "user_id,nick,sex,created,location";
            request.Nicks = "tbtest520,tbtest562";

            List<User> users = client.Execute(request, parser);
            Assert.AreEqual(2, users.Count);
            AssertUser(users[0]);
        }

        private void AssertUser(User user)
        {
            Assert.AreEqual("65753281", user.UserId);
            Assert.AreEqual("tbtest520", user.Nick);
            Assert.AreEqual("m", user.Sex);
            Assert.AreEqual("2008-03-09 02:19:35", user.CreatedStr);
            Assert.AreEqual("浙江", user.Location.State);
            Assert.AreEqual("杭州", user.Location.City);
        }
    }
}
