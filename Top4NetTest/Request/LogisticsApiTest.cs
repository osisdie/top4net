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
        private Item _item;
        private Trade _trade;

        [TestInitialize]
        public void Initialize()
        {
            ItemApiTest itemTest = new ItemApiTest();
            _item = itemTest.AddItem();
            TradeApiTest tradeTest = new TradeApiTest();
            _trade = tradeTest.AddTrade(_item);
        }

        [TestCleanup]
        public void Cleanup()
        {
            ItemApiTest itemTest = new ItemApiTest();
            if (_item != null) itemTest.DeleteItem(_item);
            TradeApiTest tradeTest = new TradeApiTest();
            if (_trade != null) tradeTest.CloseTrade(_trade);
        }

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

        [TestMethod]
        public void GetLogisticsOrdersByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            LogisticsOrdersGetRequest req = new LogisticsOrdersGetRequest();
            req.Fields = "tid,seller_nick,buyer_nick,out_sid,item_title,receiver_name,status,type";
            req.PageNo = 1;
            req.PageSize = 10;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<LogisticsOrder> rsp = client.Execute(proxy, new LogisticsOrderListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetLogisticsOrdersByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            LogisticsOrdersGetRequest req = new LogisticsOrdersGetRequest();
            req.Fields = "tid,seller_nick,buyer_nick,out_sid,item_title,receiver_name,status,type";
            req.PageNo = 1;
            req.PageSize = 10;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<LogisticsOrder> rsp = client.Execute(proxy, new LogisticsOrderListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetLogisticsOrderDetailsByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            LogisticsOrderDetailsGetRequest req = new LogisticsOrderDetailsGetRequest();
            req.Fields = "tid,seller_nick,buyer_nick,receiver_name,receiver_mobile,receiver_phone,receiver_location";
            req.PageNo = 1;
            req.PageSize = 10;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<LogisticsOrder> rsp = client.Execute(proxy, new LogisticsOrderListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
            Assert.IsNotNull(rsp.Content[0].ReceiverLocation);
        }

        [TestMethod]
        public void GetLogisticsOrderDetailsByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            LogisticsOrderDetailsGetRequest req = new LogisticsOrderDetailsGetRequest();
            req.Fields = "tid,seller_nick,buyer_nick,receiver_name,receiver_mobile,receiver_phone,receiver_location";
            req.PageNo = 1;
            req.PageSize = 10;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<LogisticsOrder> rsp = client.Execute(proxy, new LogisticsOrderListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
            Assert.IsNotNull(rsp.Content[0].ReceiverLocation);
        }

        [TestMethod]
        public void GetDeliveryAddressesByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            DeliveryAddressesGetRequest req = new DeliveryAddressesGetRequest();
            req.Fields = "address_id,receiver_name,phone,mobile,is_default,location.address,location.zip,location.city,location.district";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<DeliveryAddress> rsp = client.Execute(proxy, new DeliveryAddressListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetDeliveryAddressesByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            DeliveryAddressesGetRequest req = new DeliveryAddressesGetRequest();
            req.Fields = "address_id,receiver_name,phone,mobile,is_default,location.address,location.zip,location.city,location.district";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<DeliveryAddress> rsp = client.Execute(proxy, new DeliveryAddressListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        //[TestMethod]
        public void SendDeliveryByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            DeliverySendRequest req = new DeliverySendRequest();
            req.Tid = _trade.Tid;
            req.OrderType = "delivery_needed";
            req.CompanyCode = "POST";
            req.OutSid = "CA123456789CN";
            req.SellerName = "Carver Gu";
            req.SellerAreaId = "310115";
            req.SellerAddress = "Shanghai";
            req.SellerZip = "201203";
            req.SellerPhone = "021-57314277";
            req.SellerMobile = "13812345678";
            req.SellerMemo = "You are so lucky";
            ITopRequest proxy = new TopRequestProxy(req, _item.Nick);
            string rsp = client.Execute(proxy, new StringParser());
            Console.WriteLine(rsp);
        }
    }
}
