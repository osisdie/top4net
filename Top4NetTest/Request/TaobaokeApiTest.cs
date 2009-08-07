using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test
{
    [TestClass]
    public class TaobaokeApiTest
    {
        [TestMethod]
        public void GetTaobaokeItemsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            TaobaokeItemsGetRequest request = new TaobaokeItemsGetRequest();
            request.Fields = "iid,title,nick,pic_url,price,click_url,commission,commission_rate,commission_num,commission_volume";
            request.Pid = "sns";
            request.Keyword = "sns";
            request.StartPrice = "100";
            request.EndPrice = "200";
            request.AutoSend = "false";
            request.Area = "杭州";
            request.StartCredit = "1crown";
            request.EndCredit = "3crown";
            request.Sort = "commissionNum_desc";
            request.IsGuarantee = "true";
            request.PageSize = "6";
            request.PageNo = "1";
            List<TaobaokeItem> taobaokeItems = client.Execute(request, new TaobaokeItemListJsonParser());
            Assert.AreEqual(6, taobaokeItems.Count);
        }

        [TestMethod]
        public void GetTaobaokeItemsByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            TaobaokeItemsGetRequest request = new TaobaokeItemsGetRequest();
            request.Fields = "iid,title,nick,pic_url,price,click_url,commission,commission_rate,commission_num,commission_volume";
            request.Pid = "12345678_0_0";
            request.Keyword = "test";
            request.PageSize = "5";

            List<TaobaokeItem> taobaokeItems = client.Execute(request, new TaobaokeItemListXmlParser());
            Assert.AreEqual(5, taobaokeItems.Count);
        }
    }
}