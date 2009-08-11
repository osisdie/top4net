using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test.Parser
{
    [TestClass]
    public class TradeParserTest
    {
        [TestMethod]
        public void ParseJsonAsTrades()
        {
            string body = TestUtils.GetResourceAsText("trades.json");
            TradeListJsonParser parser = new TradeListJsonParser();
            ResponseList<Trade> rsp = parser.Parse(body);
            Assert.AreEqual(1, rsp.Content.Count);
            Assert.AreEqual(3, rsp.Content[0].OrderList.Count);
        }

        [TestMethod]
        public void ParseXmlAsTrades()
        {
            string body = TestUtils.GetResourceAsText("trades.xml");
            TradeListXmlParser parser = new TradeListXmlParser();
            ResponseList<Trade> rsp = parser.Parse(body);
            Assert.AreEqual(1, rsp.Content.Count);
            Assert.AreEqual(1, rsp.Content[0].OrderList.Count);
        }

        [TestMethod]
        public void ParseJsonAsOrders()
        {
            string body = TestUtils.GetResourceAsText("orders.json");
            OrderListJsonParser parser = new OrderListJsonParser();
            ResponseList<Order> rsp = parser.Parse(body);
            Assert.AreEqual(6, rsp.TotalResults);
            Order order = rsp.Content[0];
            Assert.AreEqual("tbtest1061", order.BuyerNick);
        }

        [TestMethod]
        public void ParseXmlAsOrders()
        {
            string body = TestUtils.GetResourceAsText("orders.xml");
            OrderListXmlParser parser = new OrderListXmlParser();
            ResponseList<Order> rsp = parser.Parse(body);
            Assert.AreEqual(6, rsp.TotalResults);
            Order order = rsp.Content[0];
            Assert.AreEqual("lilnka013", order.SellerNick);
        }
    }
}
