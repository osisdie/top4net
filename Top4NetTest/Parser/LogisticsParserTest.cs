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
            List<LogisticsCompany> companies = parser.Parse(body).Content;
            Assert.AreEqual(22, companies.Count);
        }

        [TestMethod]
        public void ParseXmlAsLogisticsCompanies()
        {
            string body = TestUtils.GetResourceAsText("logistics.companies.xml");
            LogisticsCompanyListXmlParser parser = new LogisticsCompanyListXmlParser();
            List<LogisticsCompany> companies = parser.Parse(body).Content;
            Assert.AreEqual(22, companies.Count);
        }
    }
}
