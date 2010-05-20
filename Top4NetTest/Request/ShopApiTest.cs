using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Request;

namespace Taobao.Top.Api.Test.Request
{
    [TestClass]
    public class ShopApiTest
    {
        private TopXmlRestClient client = TestUtils.GetProductTopClient();

        [TestMethod]
        public void GetShopRemainShowCase()
        {
            ShopRemainshowcaseGetRequest req = new ShopRemainshowcaseGetRequest();
            Shop shop = client.ShopRemainshowcaseGet(req, "xxx");
            Console.WriteLine(shop.Nick);
        }
    }
}
