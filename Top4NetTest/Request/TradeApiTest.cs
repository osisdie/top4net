using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Request;

namespace Taobao.Top.Api.Test.Request
{
    [TestClass]
    public class TradeApiTest
    {
        [TestMethod]
        public void GetSoldTrades()
        {
            TopXmlRestClient client = TestUtils.GetProductTopClient();
            TradesSoldGetRequest req = new TradesSoldGetRequest();
            req.Fields = "tid,buyer_nick,seller_nick,modified,orders.iid,orders.title,orders.price";
            PageList<Trade> rsp = client.TradesSoldGet(req);
            Console.WriteLine(rsp.TotalResults);
        }
    }
}
