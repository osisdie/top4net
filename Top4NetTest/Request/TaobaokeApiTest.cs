using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Request;

namespace Taobao.Top.Api.Test.Request
{
    [TestClass]
    public class TaobaokeApiTest
    {
        private TopXmlRestClient client = TestUtils.GetProductTopClient();

        [TestMethod]
        public void ConvertTaobaokeShops()
        {
            TaobaokeShopsConvertRequest req = new TaobaokeShopsConvertRequest();
            req.Fields = "user_id,shop_title,click_url,commission_rate";
            req.Sids = "34265604";
            req.Nick = "hz0799";
            PageList<TaobaokeShop> rsp = client.TaobaokeShopsConvert(req);
            Console.WriteLine(rsp.TotalResults);
        }
    }
}
