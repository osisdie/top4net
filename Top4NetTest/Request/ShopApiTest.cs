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
            SellerItemCatAddRequest req = new SellerItemCatAddRequest();
            req.Name = "Top4Net" + DateTime.Now.Ticks;
            req.ParentCid = "0";
            req.Position = 1;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            SellerItemCategory cat = client.Execute(proxy, new SellerItemCategoryJsonParser());
            Assert.IsNotNull(cat.Cid);
        }

        [TestMethod]
        public void AddSellerItemCatByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            SellerItemCatAddRequest req = new SellerItemCatAddRequest();
            req.Name = "Top4Net" + DateTime.Now.Ticks;
            req.ParentCid = "0";
            req.Position = 1;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest562");
            SellerItemCategory cat = client.Execute(proxy, new SellerItemCategoryXmlParser());
            Assert.IsNotNull(cat.Cid);
        }

        [TestMethod]
        public void UpdateSellerItemCatByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            SellerItemCategory oldCat = AddSellerItemCat();
            SellerItemCatUpdateRequest req = new SellerItemCatUpdateRequest();
            req.Cid = oldCat.Cid;
            req.Name = "Top4Net" + DateTime.Now.Ticks;
            req.Position = 2;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            SellerItemCategory cat = client.Execute(proxy, new SellerItemCategoryJsonParser());
            Assert.AreEqual(oldCat.Cid, cat.Cid);
        }

        [TestMethod]
        public void UpdateSellerItemCatByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            SellerItemCategory oldCat = AddSellerItemCat();
            SellerItemCatUpdateRequest req = new SellerItemCatUpdateRequest();
            req.Cid = oldCat.Cid;
            req.Name = "Top4Net" + DateTime.Now.Ticks;
            req.Position = 3;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            SellerItemCategory cat = client.Execute(proxy, new SellerItemCategoryXmlParser());
            Assert.AreEqual(oldCat.Cid, cat.Cid);
        }

        private SellerItemCategory AddSellerItemCat()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            SellerItemCatAddRequest req = new SellerItemCatAddRequest();
            req.Name = "Top4Net" + DateTime.Now.Ticks;
            req.ParentCid = "0";
            req.Position = 1;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            return client.Execute(proxy, new SellerItemCategoryJsonParser());
        }
    }
}
