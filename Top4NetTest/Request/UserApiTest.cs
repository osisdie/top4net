using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Request;

namespace Taobao.Top.Api.Test.Request
{
    [TestClass]
    public class UserApiTest
    {
        [TestMethod]
        public void GetUser()
        {
            TopXmlRestClient client = TestUtils.GetTestingTopClient();
            UserGetRequest req = new UserGetRequest();
            req.Fields = "nick,sex,location";
            req.Nick = "tbtest1063";
            User user = client.UserGet(req);
            Console.WriteLine(user.Nick);
        }
    }
}
