using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 订单数据结构
    /// </summary>
    public class Order : BaseObject
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        [JsonProperty("iid")]
        [XmlElement("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// 商品的最小属性单元Sku的编号
        /// </summary>
        [JsonProperty("sku_id ")]
        [XmlElement("sku_id ")]
        public string SkuId { get; set; }

        /// <summary>
        /// Sku的值
        /// </summary>
        [JsonProperty("sku_properties_name")]
        [XmlElement("sku_properties_name")]
        public string SkuProps { get; set; }

        /// <summary>
        /// 商品套餐
        /// </summary>
        [JsonProperty("item_meal_name")]
        [XmlElement("item_meal_name")]
        public string ItemCombo { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [JsonProperty("num")]
        [XmlElement("num")]
        public int ItemNum { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [JsonProperty("price")]
        [XmlElement("price")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 商品图片的绝对路径
        /// </summary>
        [JsonProperty("pic_path")]
        [XmlElement("pic_path")]
        public string ItemImgUrl { get; set; }

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
        /// 退款状态
        /// </summary>
        [JsonProperty("refund_status")]
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 子订单编号
        /// </summary>
        [JsonProperty("tid")]
        [XmlElement("tid")]
        public string ChildOid { get; set; }

        /// <summary>
        /// 商家外部编码
        /// </summary>
        [JsonProperty("outer_iid")]
        [XmlElement("outer_iid")]
        public string OuterIid { get; set; }

        /// <summary>
        /// 外部网店自己定义的SKU编码
        /// </summary>
        [JsonProperty("outer_sku_id")]
        [XmlElement("outer_sku_id")]
        public string OuterSkuId { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单超时到期时间
        /// </summary>
        [JsonProperty("timeout_action_time")]
        [XmlElement("timeout_action_time")]
        public string OrderTimeout { get; set; }

        /// <summary>
        /// 订单快照地址
        /// </summary>
        [JsonProperty("snapshot_url")]
        [XmlElement("snapshot_url")]
        public string SnapshotUrl { get; set; }

        /// <summary>
        /// 应付金额
        /// </summary>
        [JsonProperty("total_fee")]
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 实付金额
        /// </summary>
        [JsonProperty("payment")]
        [XmlElement("payment")]
        public string Payment { get; set; }

        /// <summary>
        /// 系统优惠金额
        /// </summary>
        [JsonProperty("discount_fee")]
        [XmlElement("discount_fee")]
        public string DiscountFee { get; set; }

        /// <summary>
        /// 卖家优惠金额
        /// </summary>
        [JsonProperty("adjust_fee")]
        [XmlElement("adjust_fee")]
        public string AdjustFee { get; set; }
    }
}
