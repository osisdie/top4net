using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test.Request
{
    [TestClass]
    public class TradeApiTest
    {
        private Item _item;
        private Trade _trade;

        [TestInitialize]
        public void Initialize()
        {
            ItemApiTest test = new ItemApiTest();
            _item = test.AddItem();
            _trade = AddTrade(_item);
        }

        [TestCleanup]
        public void Cleanup()
        {
            ItemApiTest test = new ItemApiTest();
            if (_item != null) test.DeleteItem(_item);
            if (_trade != null) CloseTrade(_trade);
        }

        [TestMethod]
        public void GetTradeByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            TradeGetRequest req = new TradeGetRequest();
            req.Fields = "tid,title,price,type,iid,seller_nick,buyer_nick,status";
            req.Tid = _trade.Tid;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest5");
            Trade trade = client.Execute(proxy, new TradeJsonParser());
            Assert.IsNotNull(trade);
            Assert.AreEqual(_trade.Tid, trade.Tid);
            Assert.AreEqual(_item.Iid, trade.Iid);
        }

        [TestMethod]
        public void GetTradeByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            TradeGetRequest req = new TradeGetRequest();
            req.Fields = "tid,title,price,type,iid,seller_nick,buyer_nick,status";
            req.Tid = _trade.Tid;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest5");
            Trade trade = client.Execute(proxy, new TradeXmlParser());
            Assert.IsNotNull(trade);
            Assert.AreEqual(_trade.Tid, trade.Tid);
            Assert.AreEqual(_item.Iid, trade.Iid);
        }

        [TestMethod]
        public void GetTradesByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            TradesGetRequest req = new TradesGetRequest();
            req.Fields = "tid,title,price,type,iid,seller_nick,buyer_nick,status";
            req.Iid = _item.Iid;
            req.SellerNick = _item.Nick;
            req.Type = "independent_shop_trade";
            req.PageNo = 1;
            req.PageSize = 5;
            ResponseList<Trade> rsp = client.Execute(req, new TradeListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.TotalResults >= 1);
        }

        [TestMethod]
        public void GetTradesByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            TradesGetRequest req = new TradesGetRequest();
            req.Fields = "tid,title,price,type,iid,seller_nick,buyer_nick,status";
            req.Iid = _item.Iid;
            req.SellerNick = _item.Nick;
            req.Type = "independent_shop_trade";
            req.PageNo = 1;
            req.PageSize = 5;
            ResponseList<Trade> rsp = client.Execute(req, new TradeListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.TotalResults >= 1);
        }

        [TestMethod]
        public void AddTradeMemoByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            TradeMemoAddRequest req = new TradeMemoAddRequest();
            req.Tid = _trade.Tid;
            req.Memo = "Top4net adds a memo";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest5");
            Trade trade = client.Execute(proxy, new TradeJsonParser());
            Assert.IsNotNull(trade);
            Assert.AreEqual(_trade.Tid, trade.Tid);
        }

        [TestMethod]
        public void AddTradeMemoByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            TradeMemoAddRequest req = new TradeMemoAddRequest();
            req.Tid = _trade.Tid;
            req.Memo = "Top4net adds a memo";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest5");
            Trade trade = client.Execute(proxy, new TradeXmlParser());
            Assert.IsNotNull(trade);
            Assert.AreEqual(_trade.Tid, trade.Tid);
        }

        [TestMethod]
        public void UpdateTradeMemoByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            TradeMemoUpdateRequest req = new TradeMemoUpdateRequest();
            req.Tid = _trade.Tid;
            req.Memo = "How are you doing?";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest5");
            Trade trade = client.Execute(proxy, new TradeJsonParser());
            Assert.IsNotNull(trade);
            Assert.AreEqual(_trade.Tid, trade.Tid);
        }

        [TestMethod]
        public void UpdateTradeMemoByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            TradeMemoUpdateRequest req = new TradeMemoUpdateRequest();
            req.Tid = _trade.Tid;
            req.Memo = "How are you doing?";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest5");
            Trade trade = client.Execute(proxy, new TradeXmlParser());
            Assert.IsNotNull(trade);
            Assert.AreEqual(_trade.Tid, trade.Tid);
        }

        [TestMethod]
        public void GetTradeDetailByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            TradeDetailGetRequest req = new TradeDetailGetRequest();
            req.Fields = "tid,title,price,type,iid,seller_nick,buyer_nick,status,orders";
            req.Tid = _trade.Tid;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest5");
            Trade trade = client.Execute(proxy, new TradeJsonParser());
            Assert.IsNotNull(trade);
            Assert.AreEqual(1, trade.OrderList.Count);
        }

        [TestMethod]
        public void GetTradeDetailByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            TradeDetailGetRequest req = new TradeDetailGetRequest();
            req.Fields = "tid,title,price,type,iid,seller_nick,buyer_nick,status,orders";
            req.Tid = _trade.Tid;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest5");
            Trade trade = client.Execute(proxy, new TradeXmlParser());
            Assert.IsNotNull(trade);
            Assert.AreEqual(1, trade.OrderList.Count);
        }

        [TestMethod]
        public void GetBoughtTradesByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            TradesBoughtGetRequest req = new TradesBoughtGetRequest();
            req.Fields = "tid,title,price,type,iid,seller_nick,buyer_nick,status,orders";
            req.PageNo = 1;
            req.PageSize = 5;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest5");
            ResponseList<Trade> rsp = client.Execute(proxy, new TradeListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.TotalResults > 0);
        }

        [TestMethod]
        public void GetBoughtTradesByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            TradesBoughtGetRequest req = new TradesBoughtGetRequest();
            req.Fields = "tid,title,price,type,iid,seller_nick,buyer_nick,status,orders";
            req.PageNo = 1;
            req.PageSize = 5;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<Trade> rsp = client.Execute(proxy, new TradeListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.TotalResults > 0);
        }

        [TestMethod]
        public void GetSoldTradesByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            TradesSoldGetRequest req = new TradesSoldGetRequest();
            req.Fields = "tid,title,price,type,iid,seller_nick,buyer_nick,status,orders";
            req.PageNo = 1;
            req.PageSize = 5;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<Trade> rsp = client.Execute(proxy, new TradeListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.TotalResults > 0);
        }

        [TestMethod]
        public void GetSoldTradesByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            TradesSoldGetRequest req = new TradesSoldGetRequest();
            req.Fields = "tid,title,price,type,iid,seller_nick,buyer_nick,status,orders";
            req.PageNo = 1;
            req.PageSize = 5;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<Trade> rsp = client.Execute(proxy, new TradeListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.TotalResults > 0);
        }

        [TestMethod]
        public void GetOrdersByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            OrdersGetRequest req = new OrdersGetRequest();
            req.Fields = "seller_nick,buyer_nick,title,type,created,iid,price,pic_path,num";
            req.Iid = _item.Iid;
            req.SellerNick = "tbtest561";
            req.Type = "independent_shop_trade";
            ResponseList<Order> rsp = client.Execute(req, new OrderListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.AreEqual(req.Iid, rsp.Content[0].Iid);
            Assert.AreEqual(req.SellerNick, rsp.Content[0].SellerNick);
            Assert.AreEqual(req.Type, rsp.Content[0].OrderType);
        }

        [TestMethod]
        public void GetOrdersByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            OrdersGetRequest req = new OrdersGetRequest();
            req.Fields = "seller_nick,buyer_nick,title,type,created,iid,price,pic_path,num";
            req.Iid = _item.Iid;
            req.SellerNick = "tbtest561";
            req.Type = "independent_shop_trade";
            ResponseList<Order> rsp = client.Execute(req, new OrderListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.AreEqual(req.Iid, rsp.Content[0].Iid);
            Assert.AreEqual(req.SellerNick, rsp.Content[0].SellerNick);
            Assert.AreEqual(req.Type, rsp.Content[0].OrderType);
        }

        [TestMethod]
        public void GetRefundByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            RefundGetRequest req = new RefundGetRequest();
            req.Fields = "refund_id,alipay_no,tid,oid,buyer_nick,seller_nick,address ";
            req.Rid = "126628";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest1202");
            Refund refund = client.Execute(proxy, new RefundJsonParser());
            Assert.IsNotNull(refund);
            Assert.AreEqual(req.Rid, refund.Rid);
        }

        [TestMethod]
        public void GetRefundByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            RefundGetRequest req = new RefundGetRequest();
            req.Fields = "refund_id,alipay_no,tid,oid,buyer_nick,seller_nick,address";
            req.Rid = "126628";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest1202");
            Refund refund = client.Execute(proxy, new RefundXmlParser());
            Assert.IsNotNull(refund);
            Assert.AreEqual("tbtest1202", refund.SellerNick);
            Assert.IsNotNull(refund.SellerAddress);
        }

        [TestMethod]
        public void GetAppliedRefundsByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            RefundsAppliedGetRequest req = new RefundsAppliedGetRequest();
            req.Fields = "refund_id,tid,title,buyer_nick,seller_nick";
            req.SellerNick = "tbtest1202";
            req.PageNo = 1;
            req.PageSize = 5;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest1010");
            ResponseList<Refund> rsp = client.Execute(proxy, new RefundListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetAppliedRefundsByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            RefundsAppliedGetRequest req = new RefundsAppliedGetRequest();
            req.Fields = "refund_id,tid,title,buyer_nick,seller_nick";
            req.SellerNick = "tbtest1202";
            req.PageNo = 1;
            req.PageSize = 5;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest1010");
            ResponseList<Refund> rsp = client.Execute(proxy, new RefundListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetReceivedRefundsByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            RefundsReceivedGetRequest req = new RefundsReceivedGetRequest();
            req.Fields = "refund_id,tid,title,buyer_nick,seller_nick";
            req.BuyerNick = "tbtest1010";
            req.PageNo = 1;
            req.PageSize = 5;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest1202");
            ResponseList<Refund> rsp = client.Execute(proxy, new RefundListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetReceivedRefundsByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            RefundsReceivedGetRequest req = new RefundsReceivedGetRequest();
            req.Fields = "refund_id,tid,title,buyer_nick,seller_nick";
            req.BuyerNick = "tbtest1010";
            req.PageNo = 1;
            req.PageSize = 5;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest1202");
            ResponseList<Refund> rsp = client.Execute(proxy, new RefundListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void AddRefundMessageByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            RefundMessageAddRequest req = new RefundMessageAddRequest();
            req.Rid = "126628";
            req.OwnerNick = "tbtest1202";
            req.Content = "I want to make a refund";
            req.Image = TestUtils.GetResourceAsFile("refund.jpg");
            ITopRequest proxy = new TopUploadRequestProxy(req, "tbtest1202");
            RefundMessage refundMsg = client.Execute(proxy, new RefundMessageJsonParser());
            Assert.IsNotNull(refundMsg);
        }

        [TestMethod]
        public void AddRefundMessageByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            RefundMessageAddRequest req = new RefundMessageAddRequest();
            req.Rid = "126628";
            req.OwnerNick = "tbtest1202";
            req.Content = "I want to make a refund";
            req.Image = TestUtils.GetResourceAsFile("refund.jpg");
            ITopRequest proxy = new TopUploadRequestProxy(req, "tbtest1202");
            RefundMessage refundMsg = client.Execute(proxy, new RefundMessageXmlParser());
            Assert.IsNotNull(refundMsg);
        }

        [TestMethod]
        public void GetRefundMessagesByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            RefundMessagesGetRequest req = new RefundMessagesGetRequest();
            req.Fields = "message_id,refund_id,owner_id,owner_nick,owner_role,content,picture_urls";
            req.Rid = "126628";
            req.PageNo = 1;
            req.PageSize = 5;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest1202");
            ResponseList<RefundMessage> rsp = client.Execute(proxy, new RefundMessageListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetRefundMessagesByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            RefundMessagesGetRequest req = new RefundMessagesGetRequest();
            req.Fields = "message_id,refund_id,owner_id,owner_nick,owner_role,content,picture_urls";
            req.Rid = "126628";
            req.PageNo = 1;
            req.PageSize = 5;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest1202");
            ResponseList<RefundMessage> rsp = client.Execute(proxy, new RefundMessageListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetTradeConfirmFeeByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            TradeConfirmFeeGetRequest req = new TradeConfirmFeeGetRequest();
            req.Tid = _trade.Tid;
            req.IsChildOrder = false;
            ITopRequest proxy = new TopRequestProxy(req, _item.Nick);
            ConfirmFee confirmFee = client.Execute(proxy, new ConfirmFeeJsonParser());
            Assert.IsNotNull(confirmFee);
        }

        [TestMethod]
        public void GetTradeConfirmFeeByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            TradeConfirmFeeGetRequest req = new TradeConfirmFeeGetRequest();
            req.Tid = _trade.Tid;
            req.IsChildOrder = false;
            ITopRequest proxy = new TopRequestProxy(req, _item.Nick);
            ConfirmFee confirmFee = client.Execute(proxy, new ConfirmFeeXmlParser());
            Assert.IsNotNull(confirmFee);
        }

        [TestMethod]
        public void GetIncrementSoldTradesByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            TradesSoldIncrementGetRequest req = new TradesSoldIncrementGetRequest();
            req.Fields = "tid,title,price,type,iid,seller_nick,buyer_nick,status,orders";
            req.StartModified = DateTime.ParseExact("2009-08-06", "yyyy-MM-dd", null);
            req.EndModified = DateTime.ParseExact("2009-08-07", "yyyy-MM-dd", null);
            req.Type = "fixed";
            req.PageNo = 1;
            req.PageSize = 5;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<Trade> rsp = client.Execute(proxy, new TradeListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetIncrementSoldTradesByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            TradesSoldIncrementGetRequest req = new TradesSoldIncrementGetRequest();
            req.Fields = "tid,title,price,type,iid,seller_nick,buyer_nick,status,orders";
            req.StartModified = DateTime.ParseExact("2009-08-26", "yyyy-MM-dd", null);
            req.EndModified = DateTime.ParseExact("2009-08-27", "yyyy-MM-dd", null);
            req.Type = "fixed";
            req.PageNo = 1;
            req.PageSize = 5;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            ResponseList<Trade> rsp = client.Execute(proxy, new TradeListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetTradeRatesByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            TradeRatesGetRequest req = new TradeRatesGetRequest();
            req.Fields = "content,created,item_price,nick,item_title,reated_nick;result,reply,role,tid,order_id";
            req.RateType = "get";
            req.Role = "seller";
            req.PageNo = 1;
            req.PageSize = 5;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest882");
            ResponseList<TradeRate> rsp = client.Execute(proxy, new TradeRateListJsonParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetTradeRatesByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            TradeRatesGetRequest req = new TradeRatesGetRequest();
            req.Fields = "content,created,item_price,nick,item_title,reated_nick;result,reply,role,tid,order_id";
            req.RateType = "get";
            req.Role = "seller";
            req.PageNo = 1;
            req.PageSize = 5;
            ITopRequest proxy = new TopRequestProxy(req, "tbtest882");
            ResponseList<TradeRate> rsp = client.Execute(proxy, new TradeRateListXmlParser());
            Assert.IsNotNull(rsp.Content);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        //[TestMethod]
        public void AddTradeRateByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            TradeRateAddRequest req = new TradeRateAddRequest();
            req.Tid = _trade.Tid;
            req.Result = "bad";
            req.Anonymous = true;
            req.Content = "very bad";
            req.Role = "buyer";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest5");
            string rsp = client.Execute(proxy, new StringParser());
            Console.WriteLine(rsp);
        }

        //[TestMethod]
        public void AddBatchTradeRateByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            TradeRateBatchAddRequest req = new TradeRateBatchAddRequest();
            req.Tid = _trade.Tid;
            req.Result = "good";
            req.Content = "very good";
            req.Role = "buyer";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest5");
            string rsp = client.Execute(proxy, new StringParser());
            Console.WriteLine(rsp);
        }

        internal Trade AddTrade(Item item)
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            TradeAddRequest req = new TradeAddRequest();
            req.Iids = item.Iid;
            req.Titles = "Top4Net creates a trade";
            req.Prices = "1000";
            req.Nums = "1";
            req.SellerNick = item.Nick;

            Location location = new Location();
            location.State = "浙江省";
            location.City = "杭州市";
            location.District = "西湖区";
            location.Address = "文二路";
            location.Zip = "310009";
            req.Location = location;

            req.LogisticsFee = "10";
            req.LogisticsType = "express";
            req.AreaCode = "123456";
            req.ReceiverName = "Carver";
            req.Phone = "057188888888";
            req.Mobile = "13888888888";
            req.Snapshot = "top4net-shopshopt";
            req.Type = "independent_shop_trade";

            IDictionary<string, string> orderSnapshots = new Dictionary<string, string>();
            orderSnapshots.Add("snapshot_" + item.Iid + "_", Guid.NewGuid().ToString());
            req.OrderSnapshots = orderSnapshots;

            ITopRequest proxy = new TopRequestProxy(req, "tbtest5");
            Trade trade = client.Execute(proxy, new TradeXmlParser());
            Assert.IsNotNull(trade);
            return trade;
        }

        internal void CloseTrade(Trade trade)
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            TradeCloseRequest req = new TradeCloseRequest();
            req.Tid = trade.Tid;
            req.Reason = "I don't want to buy this item";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest561");
            Trade rsp = client.Execute(proxy, new TradeJsonParser());
            Assert.AreEqual(trade.Tid, rsp.Tid);
        }
    }
}
