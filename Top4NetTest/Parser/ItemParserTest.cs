using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Parser;

namespace Taobao.Top.Api.Test.Parser
{
    [TestClass]
    public class ItemParserTest
    {
        [TestMethod]
        public void ParseJsonAsItemProps()
        {
            string body = TestUtils.GetResourceAsText("item.props.json");
            ItemPropListJsonParser parser = new ItemPropListJsonParser();
            List<ItemProp> props = parser.Parse(body).Content;
            Assert.AreEqual(7, props.Count);
            Assert.AreEqual(43, props[1].PropValueList.Count);
        }

        [TestMethod]
        public void ParseXmlAsItemProps()
        {
            string body = TestUtils.GetResourceAsText("item.props.xml");
            ItemPropListXmlParser parser = new ItemPropListXmlParser();
            List<ItemProp> props = parser.Parse(body).Content;
            Assert.AreEqual(7, props.Count);
            Assert.AreEqual(43, props[1].PropValueList.Count);
        }

        [TestMethod]
        public void ParseJsonAsItemCats()
        {
            string body = TestUtils.GetResourceAsText("item.cats.json");
            ItemCatListJsonParser parser = new ItemCatListJsonParser();
            List<ItemCategory> cats = parser.Parse(body).Content;
            Assert.AreEqual(10, cats.Count);
            Assert.AreEqual("50008825", cats[0].Cid);
        }

        [TestMethod]
        public void ParseXmlAsItemCats()
        {
            string body = TestUtils.GetResourceAsText("item.cats.xml");
            ItemCatListXmlParser parser = new ItemCatListXmlParser();
            List<ItemCategory> cats = parser.Parse(body).Content;
            Assert.AreEqual(10, cats.Count);
            Assert.AreEqual("50008825", cats[0].Cid);
        }

        [TestMethod]
        public void ParseJsonAsPropValues()
        {
            string body = TestUtils.GetResourceAsText("prop.values.json");
            PropValueListJsonParser parser = new PropValueListJsonParser();
            List<PropValue> cats = parser.Parse(body).Content;
            Assert.AreEqual(192, cats.Count);
            Assert.AreEqual("50012081", cats[0].Cid);
        }

        [TestMethod]
        public void ParseXmlAsPropValues()
        {
            string body = TestUtils.GetResourceAsText("prop.values.xml");
            PropValueListXmlParser parser = new PropValueListXmlParser();
            List<PropValue> cats = parser.Parse(body).Content;
            Assert.AreEqual(192, cats.Count);
            Assert.AreEqual("50012081", cats[0].Cid);
        }

        [TestMethod]
        public void ParseJsonAsItems()
        {
            string body = TestUtils.GetResourceAsText("items.json");
            ItemListJsonParser parser = new ItemListJsonParser();
            ResponseList<Item> items = parser.Parse(body);
            Assert.AreEqual(52316, items.TotalResults);
            Assert.AreEqual(5, items.Content.Count);
        }

        [TestMethod]
        public void ParseXmlAsItems()
        {
            string body = TestUtils.GetResourceAsText("items.xml");
            ItemListXmlParser parser = new ItemListXmlParser();
            ResponseList<Item> items = parser.Parse(body);
            Assert.AreEqual(52315, items.TotalResults);
            Assert.AreEqual(5, items.Content.Count);
        }

        [TestMethod]
        public void ParseJsonAsItemSearchs()
        {
            string body = TestUtils.GetResourceAsText("item.searchs.json");
            ItemSearchListJsonParser parser = new ItemSearchListJsonParser();
            ResponseList<ItemSearch> result = parser.Parse(body);
            Assert.AreEqual(560, result.TotalResults);
            Assert.AreEqual(1, result.Content.Count);
            ItemSearch search = result.Content[0];
            Assert.AreEqual(19, search.ItemCatList.Count);
            Assert.AreEqual(5, search.ItemList.Count);
        }

        [TestMethod]
        public void ParseXmlAsItemSearchs()
        {
            string body = TestUtils.GetResourceAsText("item.searchs.xml");
            ItemSearchListXmlParser parser = new ItemSearchListXmlParser();
            ResponseList<ItemSearch> result = parser.Parse(body);
            Assert.AreEqual(560, result.TotalResults);
            Assert.AreEqual(1, result.Content.Count);
            ItemSearch search = result.Content[0];
            Assert.AreEqual(19, search.ItemCatList.Count);
            Assert.AreEqual(5, search.ItemList.Count);
        }

        [TestMethod]
        public void ParseJsonAsItemImgs()
        {
            string body = TestUtils.GetResourceAsText("item.imgs.json");
            ItemImgListJsonParser parser = new ItemImgListJsonParser();
            ResponseList<ItemImg> imgs = parser.Parse(body);
            Assert.AreEqual(1, imgs.Content.Count);
            Assert.AreEqual("11842400", imgs.Content[0].ImgId);
        }

        [TestMethod]
        public void ParseXmlAsItemImgs()
        {
            string body = TestUtils.GetResourceAsText("item.imgs.xml");
            ItemImgListXmlParser parser = new ItemImgListXmlParser();
            ResponseList<ItemImg> imgs = parser.Parse(body);
            Assert.AreEqual(1, imgs.Content.Count);
            Assert.AreEqual("11842369", imgs.Content[0].ImgId);
        }

        [TestMethod]
        public void ParseJsonAsPropImgs()
        {
            string body = TestUtils.GetResourceAsText("prop.imgs.json");
            PropImgListJsonParser parser = new PropImgListJsonParser();
            ResponseList<PropImg> imgs = parser.Parse(body);
            Assert.AreEqual(1, imgs.Content.Count);
            Assert.AreEqual("11842402", imgs.Content[0].ImgId);
        }

        [TestMethod]
        public void ParseXmlAsPropImgs()
        {
            string body = TestUtils.GetResourceAsText("prop.imgs.xml");
            PropImgListXmlParser parser = new PropImgListXmlParser();
            ResponseList<PropImg> imgs = parser.Parse(body);
            Assert.AreEqual(1, imgs.Content.Count);
            Assert.AreEqual("11842373", imgs.Content[0].ImgId);
        }

        [TestMethod]
        public void ParseJsonAsSkus()
        {
            string body = TestUtils.GetResourceAsText("skus.json");
            SkuListJsonParser parser = new SkuListJsonParser();
            ResponseList<Sku> rsp = parser.Parse(body);
            Assert.AreEqual(1, rsp.Content.Count);
            Assert.AreEqual("1627207:28326", rsp.Content[0].SkuProps);
            Assert.AreEqual(3, rsp.Content[0].Quantity);
        }

        [TestMethod]
        public void ParseXmlAsSkus()
        {
            string body = TestUtils.GetResourceAsText("skus.xml");
            SkuListXmlParser parser = new SkuListXmlParser();
            ResponseList<Sku> rsp = parser.Parse(body);
            Assert.AreEqual(1, rsp.Content.Count);
            Assert.AreEqual("81192754", rsp.Content[0].SkuId);
            Assert.AreEqual("1700.0", rsp.Content[0].Price);
        }

        [TestMethod]
        public void ParseJsonAsPostages()
        {
            string body = TestUtils.GetResourceAsText("postages.json");
            PostageListJsonParser parser = new PostageListJsonParser();
            ResponseList<Postage> rsp = parser.Parse(body);
            Assert.AreEqual(177, rsp.Content.Count);
        }

        [TestMethod]
        public void ParseXmlAsPostages()
        {
            string body = TestUtils.GetResourceAsText("postages.xml");
            PostageListXmlParser parser = new PostageListXmlParser();
            ResponseList<Postage> rsp = parser.Parse(body);
            Assert.AreEqual(177, rsp.Content.Count);
        }
    }
}
