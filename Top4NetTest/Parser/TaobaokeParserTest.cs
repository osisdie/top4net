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

        private void AssertTaobaokeItem(TaobaokeItem item)
        {
            Assert.AreEqual("72b31835f55b6b6c35beab8c753989c1", item.Iid);
            Assert.AreEqual("淘宝客测试数据商品名称:1", item.Title);
            Assert.AreEqual("100", item.Price);
            Assert.AreEqual("淘宝客测试数据卖家昵称:1", item.Nick);
            Assert.AreEqual("22.05", item.Commission);
            Assert.AreEqual("350.00", item.CommissionRate);
            Assert.AreEqual("10", item.CommissionNum);
            Assert.AreEqual("54", item.CommissionVolume);
            Assert.IsNotNull(item.ClickUrl);
            Assert.IsNotNull(item.PicUrl);
        }

        [TestMethod]
        public void ParseJsonAsTaobaokeShops()
        {
            TaobaokeShopListJsonParser parser = new TaobaokeShopListJsonParser();
            string body = TestUtils.GetResourceAsText("taobaoke.shops.json");
            List<TaobaokeShop> shops = parser.Parse(body);
            Assert.AreEqual(3, shops.Count);
            AssertTaobaokeShop(shops[0]);
        }

        [TestMethod]
        public void ParseXmlAsTaobaokeShops()
        {
            TaobaokeShopListXmlParser parser = new TaobaokeShopListXmlParser();
            string body = TestUtils.GetResourceAsText("taobaoke.shops.xml");
            List<TaobaokeShop> shops = parser.Parse(body);
            Assert.AreEqual(3, shops.Count);
            AssertTaobaokeShop(shops[0]);
        }

        private void AssertTaobaokeShop(TaobaokeShop shop)
        {
            Assert.AreEqual("12343", shop.Uid);
            Assert.AreEqual("淘客店铺测试数据1", shop.Title);
            Assert.AreEqual("http://top.taobao.com/test1", shop.ClickUrl);
            Assert.AreEqual("10.1", shop.CommissionRate);
        }
    }
}
