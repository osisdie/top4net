using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test.Parser
{
    [TestClass]
    public class TaobaokeParserTest
    {
        [TestMethod]
        public void ParseJsonAsTaobaokeItems()
        {
            TaobaokeItemListJsonParser parser = new TaobaokeItemListJsonParser();
            string body = TestUtils.GetResourceAsText("taobaoke.items.json");
            List<TaobaokeItem> items = parser.Parse(body);
            Assert.AreEqual(2, items.Count);
            AssertTaobaokeItem(items[0]);
        }

        [TestMethod]
        public void ParseXmlAsTaobaokeItems()
        {
            TaobaokeItemListXmlParser parser = new TaobaokeItemListXmlParser();
            string body = TestUtils.GetResourceAsText("taobaoke.items.xml");
            List<TaobaokeItem> items = parser.Parse(body);
            Assert.AreEqual(2, items.Count);
            AssertTaobaokeItem(items[0]);
        }

        private void AssertTaobaokeItem(TaobaokeItem taobaokeItem)
        {
            Assert.AreEqual("72b31835f55b6b6c35beab8c753989c1", taobaokeItem.ItemId);
            Assert.AreEqual("淘宝客测试数据商品名称:1", taobaokeItem.Title);
            Assert.AreEqual("100", taobaokeItem.Price);
            Assert.AreEqual("淘宝客测试数据卖家昵称:1", taobaokeItem.Nick);
            Assert.AreEqual("22.05", taobaokeItem.Commission);
            Assert.AreEqual("350.00", taobaokeItem.CommissionRate);
            Assert.AreEqual("10", taobaokeItem.CommissionNum);
            Assert.AreEqual("54", taobaokeItem.CommissionVolume);
            Assert.IsNotNull(taobaokeItem.ClickUrl);
            Assert.IsNotNull(taobaokeItem.PicUrl);
        }
    }
}
