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
        public void ParseItemProp()
        {
            string body = TestUtils.GetResourceAsText("item.props.json");
            ItemPropListJsonParser parser = new ItemPropListJsonParser();
            List<ItemProp> props = parser.Parse(body);
            Assert.AreEqual(7, props.Count);
        }
    }
}
