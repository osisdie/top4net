using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;
using System.IO;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test.Request
{
    [TestClass]
    public class LogisticsApiTest
    {
        [TestMethod]
        public void GetAreasByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            AreasGetRequest req = new AreasGetRequest();
            req.Fields = "area_id,area_name,area_type,parent_id,zip";
            ResponseList<Area> rsp = client.Execute(req, new AreaListJsonParser());
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetAreasByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            AreasGetRequest req = new AreasGetRequest();
            req.Fields = "area_id,area_name,area_type,parent_id,zip";
            ResponseList<Area> rsp = client.Execute(req, new AreaListXmlParser());
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetLogisticsCompaniesByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            LogisticsCompaniesGetRequest req = new LogisticsCompaniesGetRequest();
            req.Fields = "company_id,company_code,company_name";
            req.IsRecommended = true;
            ResponseList<LogisticsCompany> rsp = client.Execute(req, new LogisticsCompanyListJsonParser());
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetLogisticsCompaniesByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            LogisticsCompaniesGetRequest req = new LogisticsCompaniesGetRequest();
            req.Fields = "company_id,company_code,company_name";
            req.IsRecommended = false;
            ResponseList<LogisticsCompany> rsp = client.Execute(req, new LogisticsCompanyListXmlParser());
            Assert.IsTrue(rsp.Content.Count > 0);
        }
    }
}
