using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 物流数据结构
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot( "shipping" )]
    public class Shipping
    {
        /// <summary>
        /// 交易ID
        /// </summary>
        [JsonProperty( "tid" )]
        [XmlElement( "tid" )]
        public string Tid { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [JsonProperty( "seller_nick" )]
        [XmlElement( "seller_nick" )]
        public string SellerNick { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        [JsonProperty( "buyer_nick" )]
        [XmlElement( "buyer_nick" )]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 预约取货开始时间
        /// </summary>
        [JsonProperty( "delivery_start" )]
        [XmlElement( "delivery_start" )]
        public DateTime DeliveryStart { get; set; }

        /// <summary>
        /// 预约取货结束时间
        /// </summary>
        [JsonProperty( "delivery_end" )]
        [XmlElement( "delivery_end" )]
        public DateTime DeliveryEnd { get; set; }

        /// <summary>
        /// 运单号.具体一个物流公司的运单号码.
        /// </summary>
        [JsonProperty( "out_sid" )]
        [XmlElement( "out_sid" )]
        public string OutSid { get; set; }

        /// <summary>
        /// 货物名称
        /// </summary>
        [JsonProperty( "item_title" )]
        [XmlElement( "item_title" )]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [JsonProperty( "receiver_name" )]
        [XmlElement( "receiver_name" )]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收件人电话
        /// </summary>
        [JsonProperty( "receiver_phone" )]
        [XmlElement( "receiver_phone" )]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 收件人手机号码
        /// </summary>
        [JsonProperty( "receiver_mobile" )]
        [XmlElement( "receiver_mobile" )]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 收件人地址信息
        /// </summary>
        [JsonProperty( "receiver_location" )]
        [XmlElement( "receiver_location" )]
        public Location ReceiverLocation { get; set; }

        /// <summary>
        /// 物流订单状态.可选值:
        /// CREATED(订单已创建),RECREATED(订单重新创建),CANCELLED(订单已取消),CLOSED(订单关闭), 
        /// SENDING(等候发送给物流公司), 
        /// ACCEPTING(已发送给物流公司,等待接单), 
        /// ACCEPTED(物流公司已接单), 
        /// REJECTED(物流公司不接单), 
        /// PICK_UP(物流公司揽收成功), 
        /// PICK_UP_FAILED(物流公司揽收失败), 
        /// LOST(物流公司丢单), 
        /// REJECTED_BY_RECEIVER(对方拒签), 
        /// ACCEPTED_BY_RECEIVER(对方已签收). 
        /// </summary>
        [JsonProperty( "status" )]
        [XmlElement( "status" )]
        public string Status { get; set; }

        /// <summary>
        /// 物流方式.可选值:free(卖家包邮),post(平邮),express(快递),ems(EMS).
        /// </summary>
        [JsonProperty( "type" )]
        [XmlElement( "type" )]
        public string Type { get; set; }

        /// <summary>
        /// 谁承担运费.可选值:buyer(买家承担),seller(卖家承担运费).
        /// </summary>
        [JsonProperty( "freight_payer" )]
        [XmlElement( "freight_payer" )]
        public string FreightPayer { get; set; }

        /// <summary>
        /// 卖家是否确认发货.可选值:yes(是),no(否).
        /// </summary>
        [JsonProperty( "seller_confirm" )]
        [XmlElement( "seller_confirm" )]
        public string SellerConfirm { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonProperty( "company_name" )]
        [XmlElement( "company_name" )]
        public string CompanyName { get; set; }
    }
}
