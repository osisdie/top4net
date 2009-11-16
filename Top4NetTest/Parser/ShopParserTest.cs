using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test.Parser
{
    [TestClass]
    public class ShopParserTest
    {
        [TestMethod]
        public void ParseXmlAsShops()
        {
            ShopListXmlParser parser = new ShopListXmlParser();
            string body = TestUtils.GetResourceAsText("shops.xml");
            ResponseList<Shop> rsp = parser.Parse(body);
            Assert.IsNotNull(rsp.Content);
            Assert.AreEqual(1, rsp.Content.Count);
            Assert.AreEqual("44696469", rsp.Content[0].Sid);
            Assert.AreEqual("tbtest561", rsp.Content[0].SellerNick);
        }

        [TestMethod]
        public void ParseJsonAsShop()
        {
            ShopListJsonParser parser = new ShopListJsonParser();
            string body = TestUtils.GetResourceAsText("shops.json");
            ResponseList<Shop> rsp = parser.Parse(body);
            Assert.IsNotNull(rsp.Content);
            Assert.AreEqual(1, rsp.Content.Count);
            Assert.AreEqual("店铺介绍", rsp.Content[0].Description);
            Assert.AreEqual("店铺名称", rsp.Content[0].Title);
            Assert.AreEqual("How are you doing?", rsp.Content[0].Bulletin);
        }

        [TestMethod]
        public void ParseXmlAsShopCategories()
        {
            ShopCatListXmlParser parser = new ShopCatListXmlParser();
            string body = TestUtils.GetResourceAsText("shop.cats.xml");
            ResponseList<ShopCat> rsp = parser.Parse(body);
            Assert.IsNotNull(rsp.Content);
            Assert.AreEqual(60, rsp.Content.Count);
        }

        [TestMethod]
        public void ParseJsonAsShopCategories()
        {
            ShopCatListJsonParser parser = new ShopCatListJsonParser();
            string body = TestUtils.GetResourceAsText("shop.cats.json");
            ResponseList<ShopCat> rsp = parser.Parse(body);
            Assert.IsNotNull(rsp.Content);
            Assert.AreEqual(60, rsp.Content.Count);
        }

        [TestMethod]
        public void ParseXmlAsSellerItemCategories()
        {
            SellerCatListXmlParser parser = new SellerCatListXmlParser();
            string body = TestUtils.GetResourceAsText("seller.cats.xml");
            ResponseList<SellerCat> rsp = parser.Parse(body);
            Assert.IsNotNull(rsp.Content);
            Assert.AreEqual(50, rsp.Content.Count);
        }

        [TestMethod]
        public void ParseJsonAsSellerItemCategories()
        {
            SellerCatListJsonParser parser = new SellerCatListJsonParser();
            string body = TestUtils.GetResourceAsText("seller.cats.json");
            ResponseList<SellerCat> rsp = parser.Parse(body);
            Assert.IsNotNull(rsp.Content);
            Assert.AreEqual(50, rsp.Content.Count);
        }
    }
}
