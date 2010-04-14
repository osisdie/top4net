using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Request;

namespace Taobao.Top.Api.Test.Request
{
    [TestClass]
    public class ItemApiTest
    {
        [TestMethod]
        public void SearchItems()
        {
            TopXmlRestClient client = TestUtils.GetProductTopClient();
            ItemsSearchRequest req = new ItemsSearchRequest();
            req.Fields = "iid,title,price,num,seller_nick";
            req.Q = "N73";
            ItemSearch rsp = client.ItemsSearch(req);
            Console.WriteLine(rsp.Items[0].Iid);
        }
    }
}
