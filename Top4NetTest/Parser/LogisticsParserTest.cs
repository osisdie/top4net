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
    }
}
