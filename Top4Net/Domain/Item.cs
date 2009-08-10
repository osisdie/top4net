using System;
using System.Xml.Serialization;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 商品结构
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("item")]
    public class Item
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        [JsonProperty("iid")]
        [XmlElement("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// 商品地址
        /// </summary>
        [JsonProperty("detail_url")]
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 商品数字编号
        /// </summary>
        [JsonProperty("num_iid")]
        [XmlElement("num_iid")]
        public string NumIid { get; set; }

        /// <summary>
        /// 商品标题,不能超过60字节
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [JsonProperty("nick")]
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 商品类型(fixed:一口价;auction:拍卖)
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 商品所属的叶子类目
        /// </summary>
        [JsonProperty("cid")]
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 商品所属的店铺内卖家自定义类目列表
        /// </summary>
        [JsonProperty("seller_cids")]
        [XmlElement("seller_cids")]
        public string SellerCids { get; set; }

        /// <summary>
        /// 商品属性格式：pid:vid
        /// </summary>
        [JsonProperty("props")]
        [XmlElement("props")]
        public string Props { get; set; }

        /// <summary>
        /// 用户自行输入的类目属性ID串。结构："pid1,pid2,pid3"，如："20000"（表示品牌）
        /// </summary>
        [JsonProperty("input_pids")]
        [XmlElement("input_pids")]
        public string InputPids { get; set; }

        /// <summary>
        /// 用户自行输入的子属性名和属性值
        /// </summary>
        [JsonProperty("input_str")]
        [XmlElement("input_str")]
        public string InputStrs { get; set; }

        /// <summary>
        /// 商品描述,字数要大于5个字节，小于25000个字节
        /// </summary>
        [JsonProperty("desc")]
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商品主图片地址
        /// </summary>
        [JsonProperty("pic_path")]
        [XmlElement("pic_path")]
        public string PicPath { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("num")]
        [XmlElement("num")]
        public string Num { get; set; }

        /// <summary>
        /// 有效期,7或者14（默认是14天）
        /// </summary>
        [JsonProperty("valid_thru")]
        [XmlElement("valid_thru")]
        public string ValidTerm { get; set; }

        /// <summary>
        /// 上架时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [JsonProperty("list_time")]
        [XmlElement("list_time")]
        public string EnlistTime { get; set; }

        /// <summary>
        /// 下架时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [JsonProperty("delist_time")]
        [XmlElement("delist_time")]
        public string DelistTime { get; set; }

        /// <summary>
        /// 商品新旧程度(全新:new，闲置:unused，二手：second)
        /// </summary>
        [JsonProperty("stuff_status")]
        [XmlElement("stuff_status")]
        public string StuffStatus { get; set; }

        /// <summary>
        /// 商品所在地
        /// </summary>
        [JsonProperty("location")]
        [XmlElement("location")]
        public Location Location { get; set; }

        /// <summary>
        /// 商品价格，格式：5.00；单位：元；精确到：分
        /// </summary>
        [JsonProperty("price")]
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 平邮费用,格式：5.00；单位：元；精确到：分
        /// </summary>
        [JsonProperty("post_fee")]
        [XmlElement("post_fee")]
        public string PostFee { get; set; }

        /// <summary>
        /// 快递费用,格式：5.00；单位：元；精确到：分
        /// </summary>
        [JsonProperty("express_fee")]
        [XmlElement("express_fee")]
        public string ExpressFee { get; set; }

        /// <summary>
        /// EMS费用,格式：5.00；单位：元；精确到：分
        /// </summary>
        [JsonProperty("ems_fee")]
        [XmlElement("ems_fee")]
        public string EmsFee { get; set; }

        /// <summary>
        /// 支持会员打折,true/false
        /// </summary>
        [JsonProperty("has_discount")]
        [XmlElement("has_discount")]
        public string HasDiscount { get; set; }

        /// <summary>
        /// 运费承担方式,seller（卖家承担），buyer(买家承担）
        /// </summary>
        [JsonProperty("freight_payer")]
        [XmlElement("freight_payer")]
        public string FreightPayer { get; set; }

        /// <summary>
        /// 是否有发票,true/false
        /// </summary>
        [JsonProperty("has_invoice")]
        [XmlElement("has_invoice")]
        public string HasInvoice { get; set; }

        /// <summary>
        /// 是否有保修,true/false
        /// </summary>
        [JsonProperty("has_warranty")]
        [XmlElement("has_warranty")]
        public string HasWarranty { get; set; }

        /// <summary>
        /// 橱窗推荐,true/false
        /// </summary>
        [JsonProperty("has_showcase")]
        [XmlElement("has_showcase")]
        public string HasShowcase { get; set; }

        /// <summary>
        /// 商品修改时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [JsonProperty("modified")]
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 商品创建时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [JsonProperty("created")]
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 加价幅度。如果为0，代表系统代理幅度
        /// </summary>
        [JsonProperty("increment")]
        [XmlElement("increment")]
        public string Increment { get; set; }

        /// <summary>
        /// 自动重发,true/false
        /// </summary>
        [JsonProperty("auto_repost")]
        [XmlElement("auto_repost")]
        public string AutoRepost { get; set; }

        /// <summary>
        /// 商品上传后的状态。onsale出售中，instock库中
        /// </summary>
        [JsonProperty("approve_status")]
        [XmlElement("approve_status")]
        public string ApproveStatus { get; set; }

        /// <summary>
        /// 宝贝所属的运费模板编号，如果没有返回则说明没有使用运费模板
        /// </summary>
        [JsonProperty("postage_id")]
        [XmlElement("postage_id")]
        public string PostageId { get; set; }

        /// <summary>
        /// 宝贝所属产品的编号(可能为空).该字段可以通过taobao.products.search得到
        /// </summary>
        [JsonProperty("product_id")]
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 返点比例
        /// </summary>
        [JsonProperty("auction_point")]
        [XmlElement("auction_point")]
        public string AuctionPoint { get; set; }

        /// <summary>
        /// 属性值别名
        /// </summary>
        [JsonProperty("property_alias")]
        [XmlElement("property_alias")]
        public string PropAlias { get; set; }

        /// <summary>
        /// 商家外部编码(可与商家外部系统对接)
        /// </summary>
        [JsonProperty("outer_id")]
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 虚拟商品的状态字段
        /// </summary>
        [JsonProperty("is_virtural")]
        [XmlElement("is_virtural")]
        public string IsVirtural { get; set; }

        /// <summary>
        /// 是否在淘宝显示
        /// </summary>
        [JsonProperty("is_taobao")]
        [XmlElement("is_taobao")]
        public string IsTaobao { get; set; }

        /// <summary>
        /// 是否在外部网店显示
        /// </summary>
        [JsonProperty("is_ex")]
        [XmlElement("is_ex")]
        public string IsExternal { get; set; }

        /// <summary>
        /// 商品图片列表(包括主图) 
        /// </summary>
        [JsonProperty("itemimg")]
        [XmlElement("itemimg")]
        public List<ItemImg> ItemImgList { get; set; }

        /// <summary>
        /// 商品属性图片列表
        /// </summary>
        [JsonProperty("propimg")]
        [XmlElement("propimg")]
        public List<PropImg> PropImgList { get; set; }

        /// <summary>
        /// SKU列表
        /// </summary>
        [JsonProperty("sku")]
        [XmlElement("sku")]
        public List<Sku> SkuList { get; set; }
    }
}
