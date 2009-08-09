using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test.Request
{
    [TestClass]
    public class ItemApiTest
    {
        [TestMethod]
        public void GetItemPropsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            ItemPropsGetRequest req = new ItemPropsGetRequest();
            req.Fields = "pid,name,status,sort_order";
            req.LeafCid = "1101"; //笔记本类目编号
            List<ItemProp> props = client.Execute(req, new ItemPropListJsonParser()).Content;
            Assert.AreEqual(21, props.Count);
        }

        [TestMethod]
        public void GetItemPropsByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            ItemPropsGetRequest req = new ItemPropsGetRequest();
            req.Fields = "pid,name,status,sort_order";
            req.LeafCid = "1101"; //笔记本类目编号
            List<ItemProp> props = client.Execute(req, new ItemPropListXmlParser()).Content;
            Assert.AreEqual(21, props.Count);
        }

        [TestMethod]
        public void GetItemCatsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            ItemCatsGetRequest req = new ItemCatsGetRequest();
            req.Fields = "cid,name,status,sort_order,parent_cid,is_parent";
            req.ParentCid = "0";
            List<ItemCategory> rsp = client.Execute(req, new ItemCatListJsonParser()).Content;
            Assert.AreEqual(10, rsp.Count);
        }

        [TestMethod]
        public void GetItemCatsByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            ItemCatsGetRequest req = new ItemCatsGetRequest();
            req.Fields = "cid,name,status,sort_order,parent_cid,is_parent";
            req.ParentCid = "0";
            List<ItemCategory> rsp = client.Execute(req, new ItemCatListXmlParser()).Content;
            Assert.AreEqual(10, rsp.Count);
        }

        [TestMethod]
        public void GetPropValuesByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            ItemPropValuesGetRequest req = new ItemPropValuesGetRequest();
            req.Fields = "cid,pid,prop_name,vid,name,is_parent,status,sort_order";
            req.Cid = "50012081";
            req.DateTime = DateTime.Parse("2009-01-01 00:00:00");
            List<PropValue> rsp = client.Execute(req, new PropValueListJsonParser()).Content;
            Assert.AreEqual(192, rsp.Count);
        }

        [TestMethod]
        public void GetPropValuesByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            ItemPropValuesGetRequest req = new ItemPropValuesGetRequest();
            req.Fields = "cid,name,status,sort_order,parent_cid,is_parent";
            req.Cid = "50012081";
            req.DateTime = DateTime.Parse("2009-01-01 00:00:00");
            List<PropValue> rsp = client.Execute(req, new PropValueListXmlParser()).Content;
            Assert.AreEqual(192, rsp.Count);
        }

        [TestMethod]
        public void GetBuyerItemCatsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            BuyerItemCatsGetRequest req = new BuyerItemCatsGetRequest();
            req.ParentCid = "1";
            List<ItemCategory> rsp = client.Execute(req, new ItemCatListJsonParser()).Content;
            Assert.AreEqual(10, rsp.Count);
        }

        [TestMethod]
        public void GetBuyerItemCatsByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            BuyerItemCatsGetRequest req = new BuyerItemCatsGetRequest();
            req.Cids = "1101";
            List<ItemCategory> rsp = client.Execute(req, new ItemCatListXmlParser()).Content;
            Assert.AreEqual(1, rsp.Count);
            Assert.AreEqual("笔记本电脑", rsp[0].Name);
        }

        [TestMethod]
        public void GetBuyerItemPropsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            BuyerItemPropsGetRequest req = new BuyerItemPropsGetRequest();
            req.Cid = "1101";
            List<ItemProp> rsp = client.Execute(req, new ItemPropListJsonParser()).Content;
            Assert.AreEqual(17, rsp.Count);
            Assert.AreEqual(43, rsp[0].PropValueList.Count);
        }

        [TestMethod]
        public void GetBuyerItemPropsByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            BuyerItemPropsGetRequest req = new BuyerItemPropsGetRequest();
            req.Cid = "1101";
            List<ItemProp> rsp = client.Execute(req, new ItemPropListXmlParser()).Content;
            Assert.AreEqual(17, rsp.Count);
            Assert.AreEqual(43, rsp[0].PropValueList.Count);
        }

        [TestMethod]
        public void GetBuyerItemPropByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            BuyerItemPropGetRequest req = new BuyerItemPropGetRequest();
            req.Cid = "1101";
            req.Pid = "20000";
            ItemProp rsp = client.Execute(req, new ItemPropJsonParser());
            Assert.IsNotNull(rsp);
            Assert.AreEqual(43, rsp.PropValueList.Count);
        }

        [TestMethod]
        public void GetBuyerItemPropByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            BuyerItemPropGetRequest req = new BuyerItemPropGetRequest();
            req.Cid = "1101";
            req.Pid = "20000";
            ItemProp rsp = client.Execute(req, new ItemPropXmlParser());
            Assert.IsNotNull(rsp);
            Assert.AreEqual(43, rsp.PropValueList.Count);
        }

        [TestMethod]
        public void GetItemsByJson()
        {
            ITopClient client = TestUtils.GetProductTopClient("json");
            ItemsGetRequest req = new ItemsGetRequest();
            req.Fields = "iid,title,nick,pic_path,cid,price,type,location.city,delist_time,post_fee";
            req.Query = "N73";
            req.PageNo = 1;
            req.PageSize = 5;
            string rsp = client.Execute(req, new StringParser());
            Console.WriteLine(rsp);
        }
    }
}
