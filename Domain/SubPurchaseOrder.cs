using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SubPurchaseOrder Data Structure.
    /// </summary>
    [Serializable]
    public class SubPurchaseOrder : TopObject
    {
        /// <summary>
        /// 买家实付金额。（精确到2位小数;单位:元。如:200.07，表示:200元7分）
        /// </summary>
        [XmlElement("buyer_payment")]
        public string BuyerPayment { get; set; }

        /// <summary>
        /// 创建时间。格式 yyyy-MM-dd HH:mm:ss 。
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 分销商实付金额。（精确到2位小数;单位:元。如:200.07，表示:200元7分）
        /// </summary>
        [XmlElement("distributor_payment")]
        public string DistributorPayment { get; set; }

        /// <summary>
        /// 子采购单id。
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 分销平台上商品id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 分销平台上商品商家编码。
        /// </summary>
        [XmlElement("item_outer_id")]
        public string ItemOuterId { get; set; }

        /// <summary>
        /// 商品购买数量。取值范围:大于零的整数
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 单个商品价格。（精确到2位小数;单位:元。如:200.07，表示:200元7分）
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品的SKU id。
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// SKU商家编码。
        /// </summary>
        [XmlElement("sku_outer_id")]
        public string SkuOuterId { get; set; }

        /// <summary>
        /// SKU属性值。如: 颜色:红色:别名;尺码:L:别名
        /// </summary>
        [XmlElement("sku_properties")]
        public string SkuProperties { get; set; }

        /// <summary>
        /// 快照地址。
        /// </summary>
        [XmlElement("snapshot_url")]
        public string SnapshotUrl { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品标题。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 分销商应付金额。（精确到2位小数;单位:元。如:200.07，表示:200元7分）
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }
    }
}
