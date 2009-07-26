using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test
{
    [TestClass]
    public class UserGetApiTest
    {
        public void GetUserByJson()
        {
            GetUser("json", new UserGetJsonParser());
        }

        [TestMethod]
        public void GetUserByXml()
        {
            GetUser("xml", new UserGetXmlParser());
        }

        private void GetUser(string format, ITopParser<User> parser)
        {
            ITopClient client = new TopRestClient("http://gw.sandbox.taobao.com/router/rest", "test", "test", format);
            UserGetRequest request = new UserGetRequest();
            request.Fields = "user_id,nick,sex,created,location";
            request.Nick = "tbtest520";

            User user = client.Execute(request, parser);
            Assert.AreEqual("65753281", user.UserId);
            Assert.AreEqual("tbtest520", user.Nick);
            Assert.AreEqual("m", user.Sex);
            Assert.AreEqual("2008-03-09 02:19:35", user.Created.ToString(User.DATE_TIME_FORMAT));
            Assert.AreEqual("浙江", user.Location.State);
            Assert.AreEqual("杭州", user.Location.City);
        }
    }
}
