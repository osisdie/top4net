using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Request;

namespace Taobao.Top.Api.Test.Request
{
    [TestClass]
    public class ShopApiTest
    {
        [TestMethod]
        public void GetShopCatsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            ShopCatsGetRequest req = new ShopCatsGetRequest();
            string rsp = client.Execute(req, new StringParser());
            Console.WriteLine(rsp);
        }
    }
}
