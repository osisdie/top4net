using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 退款结构
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("refund")]
    class Refund
    {
        /// <summary>
        /// 退款单号
        /// </summary>
        [JsonProperty("refund_id")]
        [XmlElement("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 淘宝交易单号
        /// </summary>
        [JsonProperty("tid")]
        [XmlElement("tid")]
        public string Tid { get; set; }

        /// <summary>
        /// 子订单号。如果是单笔交易oid会等于tid
        /// </summary>
        [JsonProperty("oid")]
        [XmlElement("oid")]
        public string Oid { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("alipay_no")]
        [XmlElement("alipay_no")]
        public string AlipayNo { get; set; }

        /// <summary>
        /// 交易总金额。精确到2位小数
        /// </summary>
        [JsonProperty("total_fee")]
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 买家nick
        /// </summary>
        [JsonProperty("buyer_nick")]
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 卖家nick
        /// </summary>
        [JsonProperty("seller_nick")]
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        #region 退款协议相关字段
        /// <summary>
        /// 退款申请时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("created")]
        [XmlElement("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// 更新时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("modified")]
        [XmlElement("modified")]
        public DateTime Modified { get; set; }

        /// <summary>
        /// 退款对应的订单交易状态。可选值:WAIT_BUYER_PAY(等待买家付款),WAIT_BUYER_CONFIRM_GOODS(卖家已发货),WAIT_SELLER_SEND_GOODS(买家已付款),TRADE_FINISHED(交易成功),TRADE_CLOSED(交易关闭),TRADE_CLOSED_BY_TAOBAO(交易被淘宝关闭),RADE_NO_CREATE_PAY(没有创建外部交易(支付宝交易))
        /// </summary>
        [JsonProperty("order_status")]
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 退款状态。可选值:WAIT_SELLER_AGREE(买家已经申请退款，等待卖家同意),WAIT_BUYER_RETURN_GOODS(卖家已经同意退款，等待买家退货),WAIT_SELLER_CONFIRM_GOODS(买家已经退货，等待卖家确认收货),CLOSED(退款关闭),SUCCESS(退款成功),SELLER_REFUSE_BUYER(卖家拒绝退款)
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 货物状态.可选值:BUYER_NOT_RECEIVED(买家未收到货),BUYER_RECEIVED(买家已收到货),买家已退货(BUYER_RETURNED_GOODS)
        /// </summary>
        [JsonProperty("good_status")]
        [XmlElement("good_status")]
        public string GoodStatus { get; set; }

        /// <summary>
        /// 买家是否需要退货。可选值:true(是),false(否)
        /// </summary>
        [JsonProperty("has_good_return")]
        [XmlElement("has_good_return")]
        public bool HasGoodReturn { get; set; }

        /// <summary>
        /// 退还金额(退还给买家的金额)。精确到2位小数
        /// </summary>
        [JsonProperty("refund_fee")]
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 支付给卖家的金额(交易总金额-退还给买家的金额)。精确到2位小数
        /// </summary>
        [JsonProperty("payment")]
        [XmlElement("payment")]
        public string Payment { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [JsonProperty("reason")]
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 退款说明
        /// </summary>
        [JsonProperty("desc")]
        [XmlElement("desc")]
        public string Desc { get; set; }
        #endregion

        #region 申请退款的商品相关字段
        /// <summary>
        /// 申请退款的商品ID
        /// </summary>
        [JsonProperty("iid")]
        [XmlElement("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 商品价格。精确到2位小数
        /// </summary>
        [JsonProperty("price")]
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品购买数量
        /// </summary>
        [JsonProperty("num")]
        [XmlElement("num")]
        public int Num { get; set; }
        #endregion

        #region 退货信息相关字段
        /// <summary>
        /// 退货时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("good_return_time")]
        [XmlElement("good_return_time")]
        public DateTime GoodReturnTime { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonProperty("company_name")]
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 退货运单号
        /// </summary>
        [JsonProperty("sid")]
        [XmlElement("sid")]
        public string Sid { get; set; }

        /// <summary>
        /// 卖家收货地址
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }
        #endregion
    }
}
