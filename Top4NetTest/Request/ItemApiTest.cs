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
        private Item _item;
        private Item _b2cItem;

        [TestInitialize]
        public void Initialize()
        {
            _item = AddItem("json", new ItemJsonParser());
            _b2cItem = AddB2cItem("json", new ItemJsonParser());
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (_item != null) DeleteItem(_item);
            if (_b2cItem != null) DeleteItem(_b2cItem);
        }

        [TestMethod]
        public void GetItemPropsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            ItemPropsGetRequest req = new ItemPropsGetRequest();
            req.Fields = "pid,name,status,sort_order";
            req.LeafCid = "1101";
            ResponseList<ItemProp> rsp = client.Execute(req, new ItemPropListJsonParser());
            Assert.AreEqual(21, rsp.Content.Count);
        }

        [TestMethod]
        public void GetItemPropsByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            ItemPropsGetRequest req = new ItemPropsGetRequest();
            req.Fields = "pid,name,status,sort_order";
            req.LeafCid = "1101";
            ResponseList<ItemProp> rsp = client.Execute(req, new ItemPropListXmlParser());
            Assert.AreEqual(21, rsp.Content.Count);
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
        public void ListItemCatsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            ItemCatsListRequest req = new ItemCatsListRequest();
            req.ParentCid = "1";
            List<ItemCategory> rsp = client.Execute(req, new ItemCatListJsonParser()).Content;
            Assert.AreEqual(10, rsp.Count);
        }

        [TestMethod]
        public void ListItemCatsByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            ItemCatsListRequest req = new ItemCatsListRequest();
            req.Cids = "1101";
            List<ItemCategory> rsp = client.Execute(req, new ItemCatListXmlParser()).Content;
            Assert.AreEqual(1, rsp.Count);
            Assert.AreEqual("笔记本电脑", rsp[0].Name);
        }

        [TestMethod]
        public void ListItemPropsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            ItemPropsListRequest req = new ItemPropsListRequest();
            req.Cid = "1101";
            List<ItemProp> rsp = client.Execute(req, new ItemPropListJsonParser()).Content;
            Assert.AreEqual(17, rsp.Count);
            Assert.AreEqual(43, rsp[0].PropValueList.Count);
        }

        [TestMethod]
        public void ListItemPropsByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            ItemPropsListRequest req = new ItemPropsListRequest();
            req.Cid = "1101";
            List<ItemProp> rsp = client.Execute(req, new ItemPropListXmlParser()).Content;
            Assert.AreEqual(17, rsp.Count);
            Assert.AreEqual(43, rsp[0].PropValueList.Count);
        }

        [TestMethod]
        public void ListItemPropByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            ItemPropListRequest req = new ItemPropListRequest();
            req.Cid = "1101";
            req.Pid = "20000";
            ItemProp rsp = client.Execute(req, new ItemPropJsonParser());
            Assert.IsNotNull(rsp);
            Assert.AreEqual(43, rsp.PropValueList.Count);
        }

        [TestMethod]
        public void ListItemPropByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            ItemPropListRequest req = new ItemPropListRequest();
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
            req.Fields = "iid,title,nick,cid,price,type";
            req.Query = "N73 IE";
            req.PageNo = 1;
            req.PageSize = 5;
            ResponseList<Item> rsp = client.Execute(req, new ItemListJsonParser());
            Assert.AreEqual(5, rsp.Content.Count);
            Assert.IsTrue(rsp.TotalResults > 5);
        }

        [TestMethod]
        public void GetItemsByXml()
        {
            ITopClient client = TestUtils.GetProductTopClient("xml");
            ItemsGetRequest req = new ItemsGetRequest();
            req.Fields = "iid,title,nick,cid,price,type";
            req.Query = "N73 IE";
            req.PageNo = 1;
            req.PageSize = 5;
            ResponseList<Item> rsp = client.Execute(req, new ItemListXmlParser());
            Assert.AreEqual(5, rsp.Content.Count);
            Assert.IsTrue(rsp.TotalResults > 5);
        }

        [TestMethod]
        public void GetItemByJson()
        {
            ITopClient client = TestUtils.GetProductTopClient("json");
            ItemGetRequest req = new ItemGetRequest();
            req.Fields = "iid,title,nick,pic_path,cid,price,type,location.city,delist_time,post_fee";
            req.Nick = "钟潭通讯科技";
            req.Iid = "1ccb4d75b4f3296ed945bb65d68fd4db";
            Item item = client.Execute(req, new ItemJsonParser());
            Assert.AreEqual("50012579", item.Cid);
        }

        [TestMethod]
        public void GetItemByXml()
        {
            ITopClient client = TestUtils.GetProductTopClient("xml");
            ItemGetRequest req = new ItemGetRequest();
            req.Fields = "iid,title,nick,pic_path,cid,price,type,location.city,delist_time,post_fee";
            req.Nick = "钟潭通讯科技";
            req.Iid = "1ccb4d75b4f3296ed945bb65d68fd4db";
            Item item = client.Execute(req, new ItemXmlParser());
            Assert.AreEqual("50012579", item.Cid);
        }

        [TestMethod]
        public void SearchItemsByJson()
        {
            ITopClient client = TestUtils.GetProductTopClient("json");
            ItemsSearchRequest req = new ItemsSearchRequest();
            req.Fields = "iid,title,nick,cid,price,type";
            req.Query = "N73 IE";
            req.PageNo = 1;
            req.PageSize = 5;
            ResponseList<ItemSearch> result = client.Execute(req, new ItemSearchListJsonParser());
            Assert.AreEqual(1, result.Content.Count);
        }

        [TestMethod]
        public void SearchItemsByXml()
        {
            ITopClient client = TestUtils.GetProductTopClient("xml");
            ItemsSearchRequest req = new ItemsSearchRequest();
            req.Fields = "iid,title,nick,cid,price,type";
            req.Query = "N73 IE";
            req.PageNo = 1;
            req.PageSize = 2;
            ResponseList<ItemSearch> result = client.Execute(req, new ItemSearchListXmlParser());
            Assert.AreEqual(1, result.Content.Count);
        }

        [TestMethod]
        public void GetOnsaleItemsByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ItemsOnsaleGetRequest req = new ItemsOnsaleGetRequest();
            req.Fields = "iid,title,nick,type,cid,num,props,price";
            req.PageNo = 2;
            req.PageSize = 5;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<Item> rsp = client.Execute(proxy, new ItemListJsonParser());
            Assert.AreEqual(5, rsp.Content.Count);
        }

        [TestMethod]
        public void GetOnsaleItemsByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ItemsOnsaleGetRequest req = new ItemsOnsaleGetRequest();
            req.Fields = "iid,title,nick,type,cid,num,props,price";
            req.PageNo = 1;
            req.PageSize = 10;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<Item> rsp = client.Execute(proxy, new ItemListXmlParser());
            Assert.AreEqual(10, rsp.Content.Count);
        }

        [TestMethod]
        public void GetAllItemsByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ItemsAllGetRequest req = new ItemsAllGetRequest();
            req.Fields = "iid,title,nick";
            req.PageNo = 1;
            req.PageSize = 20;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<Item> rsp = client.Execute(proxy, new ItemListJsonParser());
            Assert.AreEqual(20, rsp.Content.Count);
        }

        [TestMethod]
        public void GetAllItemsByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ItemsAllGetRequest req = new ItemsAllGetRequest();
            req.Fields = "iid,title,nick";
            req.PageNo = 1;
            req.PageSize = 8;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<Item> rsp = client.Execute(proxy, new ItemListXmlParser());
            Assert.AreEqual(8, rsp.Content.Count);
        }

        [TestMethod]
        public void UpdateItemByJson()
        {
            ITopClient client = TestUtils.GetProductTopClient("json");
            ItemUpdateRequest req = new ItemUpdateRequest();
            req.Iid = _item.Iid;
            req.Desc = "How are you doing";
            ITopRequest proxy = new TopRequestProxy(req, _item.Nick);
            Item item = client.Execute(req, new ItemJsonParser());
            Assert.AreEqual(req.Iid, item.Iid);
        }

        [TestMethod]
        public void UpdateItemByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ItemUpdateRequest req = new ItemUpdateRequest();
            req.Iid = _item.Iid;
            req.ApproveStatus = "instock";
            req.Title = "Updated by Top4Net";
            ITopRequest proxy = new TopRequestProxy(req, _item.Nick);
            Item item = client.Execute(proxy, new ItemXmlParser());
            Assert.AreEqual(req.Iid, item.Iid);
        }

        [TestMethod]
        public void AddItemByJson()
        {
            DeleteItem(_item);
            _item = AddItem("json", new ItemJsonParser());
        }

        [TestMethod]
        public void AddItemByXml()
        {
            DeleteItem(_item);
            _item = AddItem("xml", new ItemXmlParser());
        }

        [TestMethod]
        public void AddItemImgByJson()
        {
            AddItemImg("json", new ItemImgJsonParser());
        }

        [TestMethod]
        public void AddItemImgByXml()
        {
            AddItemImg("xml", new ItemImgXmlParser());
        }

        [TestMethod]
        public void DeleteItemImgByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ItemImg itemUpload = AddItemImg("json", new ItemImgJsonParser());

            ItemImgDeleteRequest reqDelete = new ItemImgDeleteRequest();
            reqDelete.Iid = _b2cItem.Iid;
            reqDelete.ImgId = itemUpload.ImgId;
            ITopRequest proxyDelete = new TopRequestProxy(reqDelete, _b2cItem.Nick);
            ItemImg itemDelete = client.Execute(proxyDelete, new ItemImgJsonParser());
            Assert.AreEqual(itemUpload.ImgId, itemDelete.ImgId);
        }

        //[TestMethod]
        public void DeleteItemImgByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ItemImg itemUpload = AddItemImg("xml", new ItemImgXmlParser());

            // delete uploaded item image
            ItemImgDeleteRequest reqDelete = new ItemImgDeleteRequest();
            reqDelete.Iid = _b2cItem.Iid;
            reqDelete.ImgId = itemUpload.ImgId;
            ITopRequest proxyDelete = new TopRequestProxy(reqDelete, _b2cItem.Nick);
            ItemImg itemDelete = client.Execute(proxyDelete, new ItemImgXmlParser());
            Assert.AreEqual(itemUpload.ImgId, itemDelete.ImgId);
        }

        [TestMethod]
        public void UploadItemPropImgByJson()
        {
            UploadItemPropImg("json", new PropImgJsonParser());
        }

        [TestMethod]
        public void UploadItemPropImgByXml()
        {
            UploadItemPropImg("xml", new PropImgXmlParser());
        }

        [TestMethod]
        public void DeleteItemPropImgByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            PropImg imgUpload = UploadItemPropImg("json", new PropImgJsonParser());

            ItemPropImgDeleteRequest reqDelete = new ItemPropImgDeleteRequest();
            reqDelete.Iid = _b2cItem.Iid;
            reqDelete.ImgId = imgUpload.ImgId;
            ITopRequest proxyDelete = new TopRequestProxy(reqDelete, _b2cItem.Nick);
            PropImg imgDelete = client.Execute(proxyDelete, new PropImgJsonParser());
            Assert.AreEqual(imgUpload.ImgId, imgDelete.ImgId);
        }

        //[TestMethod]
        public void DeleteItemPropImgByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            PropImg imgUpload = UploadItemPropImg("xml", new PropImgXmlParser());

            ItemPropImgDeleteRequest reqDelete = new ItemPropImgDeleteRequest();
            reqDelete.Iid = _b2cItem.Iid;
            reqDelete.ImgId = imgUpload.ImgId;
            ITopRequest proxyDelete = new TopRequestProxy(reqDelete, _b2cItem.Nick);
            PropImg imgDelete = client.Execute(proxyDelete, new PropImgXmlParser());
            Assert.AreEqual(imgUpload.ImgId, imgDelete.ImgId);
        }

        [TestMethod]
        public void GetItemSkuByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ItemSkuGetRequest req = new ItemSkuGetRequest();
            req.Fields = "sku_id,iid,properties,quantity,price,outer_id,created,modified";
            req.Nick = "tbtest561";
            req.SkuId = "81192754";
            Sku sku = client.Execute(req, new SkuJsonParser());
            Assert.IsNotNull(sku);
        }

        [TestMethod]
        public void GetItemSkuByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ItemSkuGetRequest req = new ItemSkuGetRequest();
            req.Fields = "sku_id,iid,properties,quantity,price,outer_id,created,modified";
            req.Nick = "tbtest561";
            req.SkuId = "81192754";
            Sku sku = client.Execute(req, new SkuXmlParser());
            Assert.IsNotNull(sku);
        }

        [TestMethod]
        public void AddItemSkuByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ItemSkuAddRequest req = new ItemSkuAddRequest();
            req.Iid = _item.Iid;
            req.Props = "1627207:28326";
            req.Quantity = 3;
            req.Price = "1700.00";
            ITopRequest proxy = new TopRequestProxy(req, _item.Nick);
            Sku sku = client.Execute(proxy, new SkuJsonParser());
            Assert.IsNotNull(sku);
        }

        [TestMethod]
        public void AddItemSkuByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ItemSkuAddRequest req = new ItemSkuAddRequest();
            req.Iid = _item.Iid;
            req.Props = "1627207:28326";
            req.Quantity = 3;
            req.Price = "1700";
            ITopRequest proxy = new TopRequestProxy(req, _item.Nick);
            Sku sku = client.Execute(proxy, new SkuXmlParser());
            Assert.IsNotNull(sku);
        }

        [TestMethod]
        public void UpdateItemSkuByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ItemSkuUpdateRequest req = new ItemSkuUpdateRequest();
            req.Iid = _item.Iid;
            req.Props = "1627207:28326";
            req.Quantity = 5;
            req.Price = "1700";
            ITopRequest proxy = new TopRequestProxy(req, _item.Nick);
            Sku sku = client.Execute(proxy, new SkuJsonParser());
            Assert.IsNotNull(sku);
            Assert.AreEqual(req.Iid, sku.Iid);
        }

        [TestMethod]
        public void UpdateItemSkuByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ItemSkuUpdateRequest req = new ItemSkuUpdateRequest();
            req.Iid = _item.Iid;
            req.Props = "1627207:28326";
            req.Quantity = 8;
            req.Price = "1700";
            ITopRequest proxy = new TopRequestProxy(req, _item.Nick);
            Sku sku = client.Execute(proxy, new SkuXmlParser());
            Assert.IsNotNull(sku);
            Assert.AreEqual(req.Iid, sku.Iid);
        }

        [TestMethod]
        public void GetItemSkusByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ItemSkusGetRequest req = new ItemSkusGetRequest();
            req.Fields = "sku_id,iid,properties,quantity,price,outer_id,created,modified";
            req.Iids = _item.Iid;
            req.Nick = _item.Nick;
            ResponseList<Sku> rsp = client.Execute(req, new SkuListJsonParser());
            Assert.AreEqual(1, rsp.Content.Count);
        }

        [TestMethod]
        public void GetItemSkusByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ItemSkusGetRequest req = new ItemSkusGetRequest();
            req.Fields = "sku_id,iid,properties,quantity,price,outer_id,created,modified";
            req.Iids = _item.Iid;
            req.Nick = _item.Nick;
            ResponseList<Sku> rsp = client.Execute(req, new SkuListXmlParser());
            Assert.AreEqual(1, rsp.Content.Count);
        }

        [TestMethod]
        public void EnlistItemByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ItemEnlistRequest req = new ItemEnlistRequest();
            req.Iid = _item.Iid;
            req.Num = 10;
            ITopRequest proxy = new TopRequestProxy(req, _item.Nick);
            Item item = client.Execute(proxy, new ItemJsonParser());
            Assert.AreEqual(req.Iid, item.Iid);
        }

        [TestMethod]
        public void EnlistItemByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ItemEnlistRequest req = new ItemEnlistRequest();
            req.Iid = _item.Iid;
            req.Num = 5;
            ITopRequest proxy = new TopRequestProxy(req, _item.Nick);
            Item item = client.Execute(proxy, new ItemXmlParser());
            Assert.AreEqual(req.Iid, item.Iid);
        }

        [TestMethod]
        public void GetPostagesByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            PostagesGetRequest req = new PostagesGetRequest();
            req.Fields = "postage_id,name,post_price,post_increase,express_price,express_increase,ems_price,ems_increase";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<Postage> rsp = client.Execute(proxy, new PostageListJsonParser());
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetPostagesByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            PostagesGetRequest req = new PostagesGetRequest();
            req.Fields = "postage_id,name,post_price,post_increase,express_price,express_increase,ems_price,ems_increase";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<Postage> rsp = client.Execute(proxy, new PostageListXmlParser());
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetPostageByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            PostageGetRequest req = new PostageGetRequest();
            req.Fields = "postage_id,name,post_price,post_increase,postage_mode.id,postage_mode.type";
            req.PostageId = "57228";
            req.Nick = "tbtest561";
            Postage postage = client.Execute(req, new PostageJsonParser());
            Assert.IsNotNull(postage);
            Assert.AreEqual(req.PostageId, postage.Id);
        }

        [TestMethod]
        public void GetPostageByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            PostageGetRequest req = new PostageGetRequest();
            req.Fields = "postage_id,name,post_price,post_increase,postage_mode.id,postage_mode.type";
            req.PostageId = "57228";
            req.Nick = "tbtest561";
            Postage postage = client.Execute(req, new PostageXmlParser());
            Assert.IsNotNull(postage);
            Assert.AreEqual(req.PostageId, postage.Id);
        }

        [TestMethod]
        public void AddPostageByJson()
        {
            AddPostage("json", new PostageJsonParser());
        }

        [TestMethod]
        public void AddPostageByXml()
        {
            AddPostage("xml", new PostageXmlParser());
        }

        [TestMethod]
        public void UpdatePostageByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            PostageUpdateRequest req = new PostageUpdateRequest();
            req.PostageId = "57228";
            req.Name = "笑傲江湖邮费模板";
            req.Memo = "东方不败专用";
            req.PostPrice = "6";
            req.PostIncrease = "2";
            req.ExpressPrice = "10";
            req.ExpressIncrease = "3";
            req.EmsPrice = "20";
            req.EmsIncrease = "5";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            Postage postage = client.Execute(proxy, new PostageJsonParser());
            Assert.IsNotNull(postage);
            Assert.AreEqual(req.PostageId, postage.Id);
        }

        [TestMethod]
        public void UpdatePostageByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            PostageUpdateRequest req = new PostageUpdateRequest();
            req.PostageId = "57228";
            req.Name = "CarverPostage";
            req.Memo = "卡福专用邮费模板";
            req.PostPrice = "6";
            req.PostIncrease = "2";
            req.ExpressPrice = "10";
            req.ExpressIncrease = "3";
            req.EmsPrice = "20";
            req.EmsIncrease = "5";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            Postage postage = client.Execute(proxy, new PostageXmlParser());
            Assert.IsNotNull(postage);
            Assert.AreEqual(req.PostageId, postage.Id);
        }

        [TestMethod]
        public void DeletePostageByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            Postage postageAdd = AddPostage("json", new PostageJsonParser());
            PostageDeleteRequest reqDel = new PostageDeleteRequest();
            reqDel.PostageId = postageAdd.Id;
            ITopRequest proxyDel = new TopRequestProxy(reqDel, "tbtest5");
            Postage postageDel = client.Execute(proxyDel, new PostageJsonParser());
            Assert.IsNotNull(postageDel);
            Assert.AreEqual(postageAdd.Id, postageDel.Id);
        }

        [TestMethod]
        public void DeletePostageByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            PostageDeleteRequest reqDel = new PostageDeleteRequest();
            Postage postageAdd = AddPostage("xml", new PostageXmlParser());
            reqDel.PostageId = postageAdd.Id;
            ITopRequest proxyDel = new TopRequestProxy(reqDel, "tbtest5");
            Postage postageDel = client.Execute(proxyDel, new PostageXmlParser());
            Assert.IsNotNull(postageDel);
            Assert.AreEqual(postageAdd.Id, postageDel.Id);
        }

        [TestMethod]
        public void DeleteItemByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ItemDeleteRequest req = new ItemDeleteRequest();
            req.Iid = _item.Iid;
            ITopRequest proxy = new TopRequestProxy(req, _item.Nick);
            Item item = client.Execute(proxy, new ItemJsonParser());
            Assert.IsNotNull(item);
        }

        [TestMethod]
        public void DeleteItemByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ItemDeleteRequest req = new ItemDeleteRequest();
            req.Iid = _item.Iid;
            ITopRequest proxy = new TopRequestProxy(req, _item.Nick);
            Item item = client.Execute(proxy, new ItemXmlParser());
            Assert.IsNotNull(item);
        }

        private static Item AddItem(string format, ITopParser<Item> parser)
        {
            ITopClient client = TestUtils.GetDevelopTopClient(format);
            ItemAddRequest req = new ItemAddRequest();
            req.ApproveStatus = "onsale";
            req.EnlistTime = DateTime.Now;
            req.Num = 10;
            req.Price = "1000.00";
            req.Type = "fixed";
            req.StuffStatus = "new";
            req.Title = "六脉神剑";
            req.Desc = "客户第一，员工第二，股东第三";
            Location location = new Location();
            location.State = "广东";
            location.City = "深圳";
            req.Cid = "2311";
            req.Location = location;
            req.AutoRepost = true;
            req.PostFee = "5.0";
            req.ExpressFee = "10.0";
            req.EmsFee = "20.0";
            req.Props = "21270:38756";
            req.Image = TestUtils.GetResourceAsFile("item.jpg");
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            Item item = client.Execute(proxy, parser);
            item.Nick = "tbtest561";
            Assert.IsNotNull(item);
            return item;
        }

        private static Item AddB2cItem(string format, ITopParser<Item> parser)
        {
            ITopClient client = TestUtils.GetDevelopTopClient(format);
            ItemAddRequest req = new ItemAddRequest();
            req.ApproveStatus = "instock";
            req.EnlistTime = DateTime.Now;
            req.Num = 10;
            req.Price = "1000.00";
            req.Type = "fixed";
            req.StuffStatus = "new";
            req.Title = "独孤九剑";
            req.Desc = "无招胜有招";
            Location location = new Location();
            location.State = "浙江";
            location.City = "杭州";
            req.Cid = "50012286";
            req.Location = location;
            req.AutoRepost = true;
            req.PostFee = "5.0";
            req.ExpressFee = "10.0";
            req.EmsFee = "20.0";
            req.AuctionPoint = 5;
            req.HasInvoice = true;
            req.Props = "20000:3464206;1637400:4606395;1627207:28326;21861:44860;21862:44571";
            req.SkuProps = "1627207:28326";
            req.Image = TestUtils.GetResourceAsFile("item.jpg");
            ITopRequest proxy = new TopRequestProxy(req, "b2ctest125");
            Item item = client.Execute(proxy, parser);
            item.Nick = "b2ctest125";
            Assert.IsNotNull(item);
            return item;
        }

        private ItemImg AddItemImg(string format, ITopParser<ItemImg> parser)
        {
            ITopClient client = TestUtils.GetDevelopTopClient(format);
            ItemImgUploadRequest req = new ItemImgUploadRequest();
            req.Iid = _b2cItem.Iid;
            req.Image = TestUtils.GetResourceAsFile("item.jpg");
            req.Position = 3;
            req.IsPrimary = false;
            ITopRequest proxy = new TopUploadRequestProxy(req, _b2cItem.Nick);
            ItemImg item = client.Execute(proxy, parser);
            Assert.IsNotNull(item);
            return item;
        }

        private PropImg UploadItemPropImg(string format, ITopParser<PropImg> parser)
        {
            ITopClient client = TestUtils.GetDevelopTopClient(format);
            ItemPropImgUploadRequest req = new ItemPropImgUploadRequest();
            req.Iid = _b2cItem.Iid;
            //req.Props = "1628011:4001117";
            req.Position = 2;
            req.Image = TestUtils.GetResourceAsFile("prop.jpg");
            ITopRequest proxy = new TopUploadRequestProxy(req, _b2cItem.Nick);
            PropImg img = client.Execute(proxy, parser);
            Assert.IsNotNull(img);
            return img;
        }

        private Postage AddPostage(string format, ITopParser<Postage> parser)
        {
            ITopClient client = TestUtils.GetDevelopTopClient(format);
            PostageAddRequest req = new PostageAddRequest();
            req.Name = "笑傲江湖邮费模板";
            req.Memo = "东方不败专用";
            req.PostPrice = "5";
            req.PostIncrease = "3";
            req.ExpressPrice = "5";
            req.ExpressIncrease = "4";
            req.EmsPrice = "20";
            req.EmsIncrease = "10";
            req.PostageModeType = "post;express;ems";
            req.PostageModeDest = "710000;810000,820000;140000";
            req.PostageModePrice = "11;15;20";
            req.PostageModeIncrease = "2;5;7";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest5");
            Postage postage = client.Execute(proxy, parser);
            Assert.IsNotNull(postage);
            return postage;
        }

        private void DeleteItem(Item item)
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ItemDeleteRequest req = new ItemDeleteRequest();
            req.Iid = item.Iid;
            ITopRequest proxy = new TopRequestProxy(req, item.Nick);
            Item rsp = client.Execute(proxy, new ItemJsonParser());
            Assert.IsNotNull(rsp);
        }
    }
}
