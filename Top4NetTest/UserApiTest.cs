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
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            UserGetRequest request = new UserGetRequest();
            request.Fields = "user_id,nick,sex,created,location";
            request.Nick = "tbtest520";

            User user = client.Execute(request, new UserJsonParser());
            AssertUser(user);
        }

        [TestMethod]
        public void GetUserByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            UserGetRequest request = new UserGetRequest();
            request.Fields = "user_id,nick,sex,created,location";
            request.Nick = "tbtest520";

            User user = client.Execute(request, new UserXmlParser());
            AssertUser(user);
        }

        [TestMethod]
        public void GetUsersByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            UsersGetRequest request = new UsersGetRequest();
            request.Fields = "user_id,nick,sex,created,location";
            request.Nicks = "tbtest520,tbtest562";

            List<User> users = client.Execute(request, new UserListJsonParser());
            Assert.AreEqual(2, users.Count);
            AssertUser(users[0]);
        }

        [TestMethod]
        public void GetUsersByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            UsersGetRequest request = new UsersGetRequest();
            request.Fields = "user_id,nick,sex,created,location";
            request.Nicks = "tbtest520,tbtest562";

            List<User> users = client.Execute(request, new UserListXmlParser());
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
