using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;

namespace Taobao.Top.Api.Test.Request
{
    [TestClass]
    public class MiscApiTest
    {
        [TestMethod]
        public void GetSuitesByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            SuitesGetRequest req = new SuitesGetRequest();
            req.ServiceCode = "App_Service_W_Shop";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            string rsp = client.Execute(proxy, new StringParser());
            Console.WriteLine(rsp);
        }

        [TestMethod]
        public void test()
        {
            Console.WriteLine(TestUtils.GetSandboxSessionKey("12011932", "tbtest520", "http://www.baidu.com/"));
        }
    }
}
