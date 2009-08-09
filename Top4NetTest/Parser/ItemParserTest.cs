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
            List<ItemProp> props = parser.Parse(body);
            Assert.AreEqual(7, props.Count);
            Assert.AreEqual(43, props[1].PropValueList.Count);
        }

        [TestMethod]
        public void ParseXmlAsItemProps()
        {
            string body = TestUtils.GetResourceAsText("item.props.xml");
            ItemPropListXmlParser parser = new ItemPropListXmlParser();
            List<ItemProp> props = parser.Parse(body);
            Assert.AreEqual(7, props.Count);
            Assert.AreEqual(43, props[1].PropValueList.Count);
        }

        [TestMethod]
        public void ParseJsonAsItemCats()
        {
            string body = TestUtils.GetResourceAsText("item.cats.json");
            ItemCatListJsonParser parser = new ItemCatListJsonParser();
            List<ItemCategory> cats = parser.Parse(body);
            Assert.AreEqual(10, cats.Count);
            Assert.AreEqual("50008825", cats[0].Cid);
        }

        [TestMethod]
        public void ParseXmlAsItemCats()
        {
            string body = TestUtils.GetResourceAsText("item.cats.xml");
            ItemCatListXmlParser parser = new ItemCatListXmlParser();
            List<ItemCategory> cats = parser.Parse(body);
            Assert.AreEqual(10, cats.Count);
            Assert.AreEqual("50008825", cats[0].Cid);
        }

        [TestMethod]
        public void ParseJsonAsPropValues()
        {
            string body = TestUtils.GetResourceAsText("prop.values.json");
            PropValueListJsonParser parser = new PropValueListJsonParser();
            List<PropValue> cats = parser.Parse(body);
            Assert.AreEqual(192, cats.Count);
            Assert.AreEqual("50012081", cats[0].Cid);
        }

        [TestMethod]
        public void ParseXmlAsPropValues()
        {
            string body = TestUtils.GetResourceAsText("prop.values.xml");
            PropValueListXmlParser parser = new PropValueListXmlParser();
            List<PropValue> cats = parser.Parse(body);
            Assert.AreEqual(192, cats.Count);
            Assert.AreEqual("50012081", cats[0].Cid);
        }
    }
}
