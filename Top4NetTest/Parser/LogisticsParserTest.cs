using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test.Parser
{
    [TestClass]
    public class LogisticsParserTest
    {
        [TestMethod]
        public void ParseJsonAsLogisticsCompanies()
        {
            string body = TestUtils.GetResourceAsText("logistics.companies.json");
            LogisticsCompanyListJsonParser parser = new LogisticsCompanyListJsonParser();
            ResponseList<LogisticsCompany> rsp = parser.Parse(body);
            Assert.AreEqual(22, rsp.Content.Count);
        }

        [TestMethod]
        public void ParseXmlAsLogisticsCompanies()
        {
            string body = TestUtils.GetResourceAsText("logistics.companies.xml");
            LogisticsCompanyListXmlParser parser = new LogisticsCompanyListXmlParser();
            ResponseList<LogisticsCompany> rsp = parser.Parse(body);
            Assert.AreEqual(22, rsp.Content.Count);
        }

        [TestMethod]
        public void ParseJsonAsAreas()
        {
            string body = TestUtils.GetResourceAsText("areas.json");
            AreaListJsonParser parser = new AreaListJsonParser();
            ResponseList<Area> rsp = parser.Parse(body);
            Assert.AreEqual(3707, rsp.Content.Count);
        }

        [TestMethod]
        public void ParseXmlAsAreas()
        {
            string body = TestUtils.GetResourceAsText("areas.xml");
            AreaListXmlParser parser = new AreaListXmlParser();
            ResponseList<Area> rsp = parser.Parse(body);
            Assert.AreEqual(3707, rsp.Content.Count);
        }

        [TestMethod]
        public void ParseJsonAsLogisticsOrders()
        {
            string body = TestUtils.GetResourceAsText("logistics.orders.json");
            LogisticsOrderListJsonParser parser = new LogisticsOrderListJsonParser();
            ResponseList<LogisticsOrder> rsp = parser.Parse(body);
            Assert.AreEqual(146, rsp.TotalResults);
            Assert.AreEqual(10, rsp.Content.Count);
        }

        [TestMethod]
        public void ParseXmlAsLogisticsOrders()
        {
            string body = TestUtils.GetResourceAsText("logistics.orders.xml");
            LogisticsOrderListXmlParser parser = new LogisticsOrderListXmlParser();
            ResponseList<LogisticsOrder> rsp = parser.Parse(body);
            Assert.AreEqual(146, rsp.TotalResults);
            Assert.AreEqual(10, rsp.Content.Count);
        }

        [TestMethod]
        public void ParseJsonAsDeliveryAddresses()
        {
            string body = TestUtils.GetResourceAsText("delivery.addresses.json");
            DeliveryAddressListJsonParser parser = new DeliveryAddressListJsonParser();
            ResponseList<DeliveryAddress> rsp = parser.Parse(body);
            Assert.AreEqual(8, rsp.Content.Count);
        }

        [TestMethod]
        public void ParseXmlAsDeliveryAddresses()
        {
            string body = TestUtils.GetResourceAsText("delivery.addresses.xml");
            DeliveryAddressListXmlParser parser = new DeliveryAddressListXmlParser();
            ResponseList<DeliveryAddress> rsp = parser.Parse(body);
            Assert.AreEqual(8, rsp.Content.Count);
        }
    }
}
