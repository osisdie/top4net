using System;
using System.IO;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.update
    /// </summary>
    public class ItemUpdateRequest : ITopUploadRequest
    {
        /// <summary>
        /// 需要修改的商品编号。
        /// </summary>
        public string Iid { get; set; }

        /// <summary>
        /// 商品上传后的状态。
        /// </summary>
        public string ApproveStatus { get; set; }

        /// <summary>
        /// 叶子类目编号。
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 商品属性列表。
        /// </summary>
        public string Props { get; set; }

        /// <summary>
        /// 商品数量。
        /// </summary>
        public string Num { get; set; }

        /// <summary>
        /// 商品价格。
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 宝贝标题。
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 商品描述。
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 所在地省份。
        /// </summary>
        public string LocationState { get; set; }

        /// <summary>
        /// 所在地城市。
        /// </summary>
        public string LocationCity { get; set; }

        /// <summary>
        /// 运费承担方式。
        /// </summary>
        public string FreightPayer { get; set; }

        /// <summary>
        /// 有效期。
        /// </summary>
        public string ValidTerm { get; set; }

        /// <summary>
        /// 是否有发票。
        /// </summary>
        public bool HasInvoice { get; set; }

        /// <summary>
        /// 是否有保修。
        /// </summary>
        public bool HasWarranty { get; set; }

        /// <summary>
        /// 是否自动上架。
        /// </summary>
        public bool AutoRepost { get; set; }

        /// <summary>
        /// 是否橱窗推荐。
        /// </summary>
        public bool HasShowcase { get; set; }

        /// <summary>
        /// 店铺类目列表。
        /// </summary>
        public string SellerCids { get; set; }

        /// <summary>
        /// 是否支持会员打折。
        /// </summary>
        public bool HasDiscount { get; set; }

        /// <summary>
        /// 平邮费用。
        /// </summary>
        public string PostFee { get; set; }

        /// <summary>
        /// 快递费用。
        /// </summary>
        public string ExpressFee { get; set; }

        /// <summary>
        /// EMS费用。
        /// </summary>
        public string EmsFee { get; set; }

        /// <summary>
        /// 上架时间。
        /// </summary>
        public string EnlistTime { get; set; }

        /// <summary>
        /// 加价幅度。
        /// </summary>
        public string Increment { get; set; }

        /// <summary>
        /// 商品图片。
        /// </summary>
        public FileInfo Image { get; set; }

        /// <summary>
        /// 商品新旧程度。
        /// </summary>
        public string StuffStatus { get; set; }

        /// <summary>
        /// 商品的积分返点比例。
        /// </summary>
        public string AuctionPoint { get; set; }

        /// <summary>
        /// 属性值别名串。
        /// </summary>
        public string PropAlias { get; set; }

        /// <summary>
        /// 用户自行输入的类目属性编号串。
        /// </summary>
        public string InputPids { get; set; }

        /// <summary>
        /// 用户自行输入的类目属性别名串。
        /// </summary>
        public string InputStrs { get; set; }

        /// <summary>
        /// 更新的sku的数量串。
        /// </summary>
        public string SkuQuantities { get; set; }

        /// <summary>
        /// 更新的sku的价格串。
        /// </summary>
        public string SkuPrices { get; set; }

        /// <summary>
        /// 更新的sku的属性串。
        /// </summary>
        public string SkuProps { get; set; }

        /// <summary>
        /// 宝贝所属的运费模板编号。
        /// </summary>
        public string PostageId { get; set; }

        /// <summary>
        /// 商品文字的版本。
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// 商家外部编码。
        /// </summary>
        public string OuterId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("iid", this.Iid);
            parameters.Add("approve_status", this.ApproveStatus);
            parameters.Add("cid", this.Cid);
            parameters.Add("props", this.Props);
            parameters.Add("num", this.Num);
            parameters.Add("price", this.Price);
            parameters.Add("title", this.Title);
            parameters.Add("desc", this.Desc);
            parameters.Add("location.state", this.LocationState);
            parameters.Add("location.city", this.LocationCity);
            parameters.Add("freight_payer", this.FreightPayer);
            parameters.Add("valid_thru", this.ValidTerm);
            parameters.Add("has_invoice", this.HasInvoice + "");
            parameters.Add("has_warranty", this.HasWarranty + "");
            parameters.Add("auto_repost", this.AutoRepost + "");
            parameters.Add("has_showcase", this.HasShowcase + "");
            parameters.Add("seller_cids", this.SellerCids);
            parameters.Add("has_discount", this.HasDiscount + "");
            parameters.Add("post_fee", this.PostFee);
            parameters.Add("express_fee", this.ExpressFee);
            parameters.Add("ems_fee", this.EmsFee);
            parameters.Add("list_time", this.EnlistTime);
            parameters.Add("increment", this.Increment);
            parameters.Add("stuff_status", this.StuffStatus);
            parameters.Add("auction_point", this.AuctionPoint);
            parameters.Add("property_alias", this.PropAlias);
            parameters.Add("input_pids", this.InputPids);
            parameters.Add("input_str", this.InputStrs);
            parameters.Add("sku_quantities", this.SkuQuantities);
            parameters.Add("sku_prices", this.SkuPrices);
            parameters.Add("sku_properties", this.SkuProps);
            parameters.Add("postage_id", this.PostageId);
            parameters.Add("lang", this.Language);
            parameters.Add("outer_id", this.OuterId);

            return parameters;
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileInfo> GetFileParameters()
        {
            IDictionary<string, FileInfo> parameters = new Dictionary<string, FileInfo>();
            parameters.Add("image", this.Image);
            return parameters;
        }

        #endregion
    }
}
