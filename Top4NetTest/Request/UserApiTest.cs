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
            TopXmlRestClient client = TestUtils.GetProductTopClient();
            UserGetRequest req = new UserGetRequest();
            req.Fields = "nick,sex,location";
            req.Nick = "hz0799";
            User user = client.UserGet(req);
            Console.WriteLine(user.Nick);
        }

        [TestMethod]
        public void GetUsers()
        {
            TopXmlRestClient client = TestUtils.GetProductTopClient();
            UsersGetRequest req = new UsersGetRequest();
            req.Fields = "nick,sex,buyer_credit,seller_credit,location";
            req.Nicks = "hz0799,dahon";
            PageList<User> rsp = client.UsersGet(req);
            Console.WriteLine(rsp.TotalResults);
        }
    }
}
