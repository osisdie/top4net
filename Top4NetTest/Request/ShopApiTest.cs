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
            ResponseList<ShopCat> rsp = client.Execute(req, new ShopCatListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetShopCatsByXml()
        {
            ITopClient client = TestUtils.GetProductTopClient("xml");
            ShopCatsGetRequest req = new ShopCatsGetRequest();
            ResponseList<ShopCat> rsp = client.Execute(req, new ShopCatListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetSellerItemCatsByJson()
        {
            ITopClient client = TestUtils.GetProductTopClient("json");
            SellerCatsGetRequest req = new SellerCatsGetRequest();
            req.Nick = "驴友之家";
            ResponseList<SellerCat> rsp = client.Execute(req, new SellerCatListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetSellerItemCatsByXml()
        {
            ITopClient client = TestUtils.GetProductTopClient("xml");
            SellerCatsGetRequest req = new SellerCatsGetRequest();
            req.Nick = "驴友之家";
            ResponseList<SellerCat> rsp = client.Execute(req, new SellerCatListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void UpdateShopByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ShopUpdateRequest req = new ShopUpdateRequest();
            req.Title = "快乐女生大本营";
            req.Bulletin = "快乐2009";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            Shop shop = client.Execute(proxy, new ShopJsonParser());
            Assert.AreEqual("44696469", shop.Sid);
        }

        [TestMethod]
        public void UpdateShopByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ShopUpdateRequest req = new ShopUpdateRequest();
            req.Title = "测试组三剑客";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest562");
            Shop shop = client.Execute(proxy, new ShopXmlParser());
            Assert.AreEqual("44566468", shop.Sid);
        }

        [TestMethod]
        public void AddSellerItemCatByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            SellerCatAddRequest req = new SellerCatAddRequest();
            req.Name = "Top4Net" + DateTime.Now.Ticks;
            req.ParentCid = "0";
            req.Position = 1;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            SellerCat cat = client.Execute(proxy, new SellerCatJsonParser());
            Assert.IsNotNull(cat.Cid);
        }

        [TestMethod]
        public void AddSellerItemCatByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            SellerCatAddRequest req = new SellerCatAddRequest();
            req.Name = "Top4Net" + DateTime.Now.Ticks;
            req.ParentCid = "0";
            req.Position = 1;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest562");
            SellerCat cat = client.Execute(proxy, new SellerCatXmlParser());
            Assert.IsNotNull(cat.Cid);
        }

        [TestMethod]
        public void UpdateSellerItemCatByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            SellerCat oldCat = AddSellerItemCat();
            SellerCatUpdateRequest req = new SellerCatUpdateRequest();
            req.Cid = oldCat.Cid;
            req.Name = "Top4Net" + DateTime.Now.Ticks;
            req.Position = 2;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            SellerCat cat = client.Execute(proxy, new SellerCatJsonParser());
            Assert.AreEqual(oldCat.Cid, cat.Cid);
        }

        [TestMethod]
        public void UpdateSellerItemCatByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            SellerCat oldCat = AddSellerItemCat();
            SellerCatUpdateRequest req = new SellerCatUpdateRequest();
            req.Cid = oldCat.Cid;
            req.Name = "Top4Net" + DateTime.Now.Ticks;
            req.Position = 3;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            SellerCat cat = client.Execute(proxy, new SellerCatXmlParser());
            Assert.AreEqual(oldCat.Cid, cat.Cid);
        }

        private SellerCat AddSellerItemCat()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            SellerCatAddRequest req = new SellerCatAddRequest();
            req.Name = "Top4Net" + DateTime.Now.Ticks;
            req.ParentCid = "0";
            req.Position = 1;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            return client.Execute(proxy, new SellerCatJsonParser());
        }
    }
}
