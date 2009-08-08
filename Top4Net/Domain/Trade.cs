using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 交易结构
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("trade")]
    class Trade
    {
        /// <summary>
        /// 淘宝交易编号(父订单的交易编号)
        /// </summary>
        [JsonProperty("tid")]
        [XmlElement("tid")]
        public string Tid { get; set; }

        /// <summary>
        /// 交易标题.以店铺名作为此标题的值.注:taobao.trades.get接口返回的Trade中的title是商品名称
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 交易类型。可选值:fixed(一口价),auction(拍卖),guarantee_trade(一口价、拍卖),auto_delivery(自动发货),independent_shop_trade(外部网店),ec(直冲),cod(货到付款)
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 交易创建时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("created")]
        [XmlElement("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [JsonProperty("seller_nick")]
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        [JsonProperty("buyer_nick")]
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 买家留言
        /// </summary>
        [JsonProperty("buyer_message")]
        [XmlElement("buyer_message")]
        public string BuyerMessage { get; set; }

        /// <summary>
        /// 商品的编号.可以通过taobao.item.get获取详细的商品Item的信息
        /// </summary>
        [JsonProperty("iid")]
        [XmlElement("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// 商品价格。精确到2位小数,单位:元。如:200.07，表示:200元7分
        /// </summary>
        [JsonProperty("price")]
        [XmlElement("price")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 商品图片绝对地址
        /// </summary>
        [JsonProperty("pic_path")]
        [XmlElement("pic_path")]
        public string ItemPicUrl { get; set; }

        /// <summary>
        /// 商品购买数量。取值范围:大于零的整数
        /// </summary>
        [JsonProperty("num")]
        [XmlElement("num")]
        public int ItemNum { get; set; }

        /// <summary>
        /// 物流编号
        /// </summary>
        [JsonProperty("sid")]
        [XmlElement("sid")]
        public string Sid { get; set; }

        /// <summary>
        /// 创建交易时的物流方式。可选值:free(卖家承担运费),post(平邮),express(快递),ems(EMS),virtual(虚拟物品)
        /// </summary>
        [JsonProperty("shipping_type")]
        [XmlElement("shipping_type")]
        public string ShippingType { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("alipay_no")]
        [XmlElement("alipay_no")]
        public string AlipayNo { get; set; }

        /// <summary>
        /// 买家实付金额（包含物流费用）。精确到2位小数
        /// </summary>
        [JsonProperty("payment")]
        [XmlElement("payment")]
        public string Payment { get; set; }

        /// <summary>
        /// 系统优惠金额。精确到2位小数,单位:元。如:200.07，表示:200元7分
        /// </summary>
        [JsonProperty("discount_fee")]
        [XmlElement("discount_fee")]
        public string DiscountFee { get; set; }

        /// <summary>
        /// 卖家优惠金额。精确到2位小数,单位:元。如:200.07，表示:200元7分
        /// </summary>
        [JsonProperty("adjust_fee")]
        [XmlElement("adjust_fee")]
        public string AdjustFee { get; set; }

        /// <summary>
        /// 交易快照地址
        /// </summary>
        [JsonProperty("snapshot_url")]
        [XmlElement("snapshot_url")]
        public string SnapshotUrl { get; set; }

        /// <summary>
        /// 交易状态。可选值:
        /// TRADE_NO_CREATE_PAY(没有创建支付宝交易),
        /// WAIT_BUYER_PAY(等待买家付款),
        /// WAIT_SELLER_SEND_GOODS(等待卖家发货,即:买家已付款),
        /// WAIT_BUYER_CONFIRM_GOODS(等待买家确认收货,即:卖家已发货),
        /// TRADE_BUYER_SIGNED(买家已签收,货到付款专用),
        /// TRADE_FINISHED(交易成功),
        /// TRADE_CLOSED(交易关闭),
        /// TRADE_CLOSED_BY_TAOBAO(交易被淘宝关闭),
        /// ALL_WAIT_PAY(包含：WAIT_BUYER_PAY、TRADE_NO_CREATE_PAY),
        /// ALL_CLOSED(包含：TRADE_CLOSED、TRADE_CLOSED_BY_TAOBAO)
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 卖家是否已评价。可选值:true(已评价),false(未评价)
        /// </summary>
        [JsonProperty("seller_rate")]
        [XmlElement("seller_rate")]
        public bool SellerRate { get; set; }

        /// <summary>
        /// 买家是否已评价。可选值:true(已评价),false(未评价)
        /// </summary>
        [JsonProperty("buyer_rate")]
        [XmlElement("buyer_rate")]
        public bool BuyerRate { get; set; }

        /// <summary>
        /// 买家备注
        /// </summary>
        [JsonProperty("buyer_memo")]
        [XmlElement("buyer_memo")]
        public string BuyerMemo { get; set; }

        /// <summary>
        /// 卖家备注
        /// </summary>
        [JsonProperty("seller_memo")]
        [XmlElement("seller_memo")]
        public string SellerMemo { get; set; }

        /// <summary>
        /// 付款时间。格式:yyyy-MM-ddHH:mm:ss
        /// </summary>
        [JsonProperty("pay_time")]
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 交易成功时间(更新交易状态为成功的同时更新)/确认收货时间。格式:yyyy-MM-ddHH:mm:ss
        /// </summary>
        [JsonProperty("end_time")]
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 交易修改时间(用户对订单的操作会更新此字段)。格式:yyyy-MM-ddHH:mm:ss
        /// </summary>
        [JsonProperty("modified")]
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 买家获得积分,返点的积分。格式:100,单位:个
        /// </summary>
        [JsonProperty("buyer_obtain_point_fee")]
        [XmlElement("buyer_obtain_point_fee")]
        public string BuyerObtainPointFee { get; set; }

        /// <summary>
        /// 买家使用积分。格式:100
        /// </summary>
        [JsonProperty("point_fee")]
        [XmlElement("point_fee")]
        public string BuyerUsePointFee { get; set; }

        /// <summary>
        /// 买家实际使用积分。格式:100,单位:个.
        /// </summary>
        [JsonProperty("real_point_fee")]
        [XmlElement("real_point_fee")]
        public string BuyerRealPointFee { get; set; }

        /// <summary>
        /// 金额。精确到2位小数
        /// </summary>
        [JsonProperty("total_fee")]
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 邮费。精确到2位小数,单位:元。如:200.07，表示:200元7分
        /// </summary>
        [JsonProperty("post_fee")]
        [XmlElement("post_fee")]
        public string PostFee { get; set; }

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        [JsonProperty("buyer_alipay_no")]
        [XmlElement("buyer_alipay_no")]
        public string BuyerAlipayNo { get; set; }

        /// <summary>
        /// 收货人的姓名
        /// </summary>
        [JsonProperty("receiver_name")]
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人的所在省份
        /// </summary>
        [JsonProperty("receiver_state")]
        [XmlElement("receiver_state")]
        public string ReceiverState { get; set; }

        /// <summary>
        /// 收货人的所在城市
        /// </summary>
        [JsonProperty("receiver_city")]
        [XmlElement("receiver_city")]
        public string ReceiverCity { get; set; }

        /// <summary>
        /// 收货人的所在地区
        /// </summary>
        [JsonProperty("receiver_district")]
        [XmlElement("receiver_district")]
        public string ReceiverDistrict { get; set; }

        /// <summary>
        /// 收货人的详细地址
        /// </summary>
        [JsonProperty("receiver_address")]
        [XmlElement("receiver_address")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 收货人的邮编
        /// </summary>
        [JsonProperty("receiver_zip")]
        [XmlElement("receiver_zip")]
        public string ReceiverZip { get; set; }

        /// <summary>
        /// 收货人的手机号码
        /// </summary>
        [JsonProperty("receiver_mobile")]
        [XmlElement("receiver_mobile")]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 收货人的电话号码
        /// </summary>
        [JsonProperty("receiver_phone")]
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 卖家发货时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("consign_time")]
        [XmlElement("consign_time")]
        public string ConsignTime { get; set; }

        /// <summary>
        /// 买家Email
        /// </summary>
        [JsonProperty("buyer_email")]
        [XmlElement("buyer_email")]
        public string BuyerEmail { get; set; }

        /// <summary>
        /// 交易佣金。精确到2位小数
        /// </summary>
        [JsonProperty("commission_fee")]
        [XmlElement("commission_fee")]
        public string CommissionFee { get; set; }

        /// <summary>
        /// 卖家支付宝账号
        /// </summary>
        [JsonProperty("seller_alipay_no")]
        [XmlElement("seller_alipay_no")]
        public string SellerAlipayNo { get; set; }

        /// <summary>
        /// 卖家手机
        /// </summary>
        [JsonProperty("seller_mobile")]
        [XmlElement("seller_mobile")]
        public string SellerMobile { get; set; }

        /// <summary>
        /// 卖家电话
        /// </summary>
        [JsonProperty("seller_phone")]
        [XmlElement("seller_phone")]
        public string SellerPhone { get; set; }

        /// <summary>
        /// 卖家姓名
        /// </summary>
        [JsonProperty("seller_name")]
        [XmlElement("seller_name")]
        public string SellerName { get; set; }

        /// <summary>
        /// 卖家Email
        /// </summary>
        [JsonProperty("seller_email")]
        [XmlElement("seller_email")]
        public string SellerEmail { get; set; }

        /// <summary>
        /// 能够确认收货的实付款。精确到2位小数
        /// </summary>
        [JsonProperty("available_confirm_fee")]
        [XmlElement("available_confirm_fee")]
        public string AvailableConfirmFee { get; set; }

        /// <summary>
        /// 是否包含邮费。与available_confirm_fee同时使用。可选值:true(包含),false(不包含)
        /// </summary>
        [JsonProperty("has_postFee")]
        [XmlElement("has_postFee")]
        public string HasPostFee { get; set; }

        /// <summary>
        /// 卖家实际收到的支付宝打款金额。精确到2位小数
        /// </summary>
        [JsonProperty("received_payment")]
        [XmlElement("received_payment")]
        public string ReceivedPayment { get; set; }

        /// <summary>
        /// 货到付款服务费。精确到2位小数
        /// </summary>
        [JsonProperty("cod_fee")]
        [XmlElement("cod_fee")]
        public string CodFee { get; set; }

        /// <summary>
        /// 超时到期时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("timeout_action_time")]
        [XmlElement("timeout_action_time")]
        public string TimeoutActionTime { get; set; }

        /// <summary>
        /// 订单列表
        /// </summary>
        [JsonProperty("orders")]
        [XmlElement("orders")]
        public List<Order> Orders { get; set; }
    }
}
