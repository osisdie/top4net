using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemextra.update
    /// </summary>
    public class ItemExtraUpdateRequest : ITopRequest
    {
        /// <summary>
        /// 商品编号。
        /// </summary>
        public string Iid { get; set; }

        /// <summary>
        /// 商品标题。
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 商品描述。
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 自定义信息。
        /// </summary>
        public string Feature { get; set; }

        /// <summary>
        /// 商品备注。
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 扩展类型。
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 预订金。
        /// </summary>
        public string ReservePrice { get; set; }

        /// <summary>
        /// SKU的属性串。
        /// </summary>
        public string SkuProps { get; set; }

        /// <summary>
        /// sku的数量串。
        /// </summary>
        public string SkuQuantities { get; set; }

        /// <summary>
        /// sku的价格串。
        /// </summary>
        public string SkuPrices { get; set; }

        /// <summary>
        /// Sku的备注串。
        /// </summary>
        public string SkuMemos { get; set; }

        /// <summary>
        /// Sku的编号串。
        /// </summary>
        public string SkuIds { get; set; }

        /// <summary>
        /// Sku的主键串。
        /// </summary>
        public string SkuExtraIds { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemextra.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("iid", this.Iid);
            parameters.Add("title", this.Title);
            parameters.Add("desc", this.Desc);
            parameters.Add("feature", this.Feature);
            parameters.Add("memo", this.Memo);
            parameters.Add("type", this.Type);
            parameters.Add("reserve_price", this.ReservePrice);
            parameters.Add("sku_properties", this.SkuProps);
            parameters.Add("sku_quantities", this.SkuQuantities);
            parameters.Add("sku_prices", this.SkuPrices);
            parameters.Add("sku_memos", this.SkuMemos);
            parameters.Add("sku_ids", this.SkuIds);
            parameters.Add("sku_extra_ids", this.SkuExtraIds);

            return parameters;
        }

        #endregion
    }
}
