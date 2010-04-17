using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Request;

namespace Taobao.Top.Api.Test.Request
{
    [TestClass]
    public class UserApiTest
    {
        private TopXmlRestClient client = TestUtils.GetProductTopClient();

        [TestMethod]
        public void GetUser()
        {
            UserGetRequest req = new UserGetRequest();
            req.Fields = "nick,sex,location";
            req.Nick = "hz0799";
            User user = client.UserGet(req);
            Console.WriteLine(user.Nick);
        }

        [TestMethod]
        public void GetUsers()
        {
            UsersGetRequest req = new UsersGetRequest();
            req.Fields = "nick,sex,buyer_credit,seller_credit,location";
            req.Nicks = "hz0799,dahon";
            PageList<User> rsp = client.UsersGet(req);
            Console.WriteLine(rsp.TotalResults);
        }

        [TestMethod]
        public void GetUserWithDynamicRequest()
        {
            DynamicTopRequest req = new DynamicTopRequest("taobao.user.get");
            req.AddTextParameter("fields", "nick,sex,location");
            req.AddTextParameter("nick", "hz0799");
            string rsp = client.GetResponse(req);
            Console.WriteLine(rsp);
        }
    }
}
