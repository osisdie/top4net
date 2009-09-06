using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Request;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test.Request
{
    [TestClass]
    public class ShopApiTest
    {
        [TestMethod]
        public void GetShopByJson()
        {
            ITopClient client = TestUtils.GetProductTopClient("json");
            ShopGetRequest req = new ShopGetRequest();
            req.Fields = "sid,cid,title,nick,desc,bulletin,pic_path,created,modified";
            req.Nick = "驴友之家";
            Shop shop = client.Execute(req, new ShopJsonParser());
            Assert.IsNotNull(shop);
            Assert.AreEqual(req.Nick, shop.SellerNick);
        }

        [TestMethod]
        public void GetShopByXml()
        {
            ITopClient client = TestUtils.GetProductTopClient("xml");
            ShopGetRequest req = new ShopGetRequest();
            req.Fields = "sid,cid,title,nick,desc,bulletin,pic_path,created,modified";
            req.Nick = "驴友之家";
            Shop shop = client.Execute(req, new ShopXmlParser());
            Assert.IsNotNull(shop);
            Assert.AreEqual(req.Nick, shop.SellerNick);
        }

        [TestMethod]
        public void GetShopCatsByJson()
        {
            ITopClient client = TestUtils.GetProductTopClient("json");
            ShopCatsGetRequest req = new ShopCatsGetRequest();
            ResponseList<ShopCategory> rsp = client.Execute(req, new ShopCategoryListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetShopCatsByXml()
        {
            ITopClient client = TestUtils.GetProductTopClient("xml");
            ShopCatsGetRequest req = new ShopCatsGetRequest();
            ResponseList<ShopCategory> rsp = client.Execute(req, new ShopCategoryListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetSellerItemCatsByJson()
        {
            ITopClient client = TestUtils.GetProductTopClient("json");
            SellerItemCatsGetRequest req = new SellerItemCatsGetRequest();
            req.Nick = "驴友之家";
            ResponseList<SellerItemCategory> rsp = client.Execute(req, new SellerItemCategoryListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetSellerItemCatsByXml()
        {
            ITopClient client = TestUtils.GetProductTopClient("xml");
            SellerItemCatsGetRequest req = new SellerItemCatsGetRequest();
            req.Nick = "驴友之家";
            ResponseList<SellerItemCategory> rsp = client.Execute(req, new SellerItemCategoryListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }
    }
}
