using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemextra.update
    /// </summary>
    public class ItemExtraUpdateRequest : ITopPrivateRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 商品id。
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// 标题。
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 自定义信息 。
        /// </summary>
        public string Feature { get; set; }

        /// <summary>
        /// 备注 。
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 扩展类型 other:其他网店 ；uniqlo: 优衣库 reserve_price。
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 预订金 100.12元。
        /// </summary>
        public string ReservePrice { get; set; }

        /// <summary>
        /// SKU的属性串，pid11:vid11;pid12:vid12,pid21:vid21;pid22:vid22,…。
        /// </summary>
        public string SkuProperties { get; set; }

        /// <summary>
        /// sku的数量串，结构如：2,3,…。
        /// </summary>
        public string SkuQuantities { get; set; }

        /// <summary>
        /// sku的价格串，结构如：10.00,5.00,…。
        /// </summary>
        public string SkuPrices { get; set; }

        /// <summary>
        /// Sku 的备注串，结构如：2,3,…。
        /// </summary>
        public string SkuMemos { get; set; }

        /// <summary>
        /// Sku_id串 可以为空，如果为空，为新SKU。
        /// </summary>
        public string SkuIds { get; set; }

        /// <summary>
        /// Sku主键串。
        /// </summary>
        public string SkuExtraIds { get; set; }

        /// <summary>
        /// 产品主图文件绝对地址。
        /// </summary>
        public string PrimaryPicPath { get; set; }

        public ItemExtraUpdateRequest(string sessionKey)
        {
            if (string.IsNullOrEmpty(sessionKey))
            {
                throw new ArgumentNullException("sessionKey");
            }
            this.sessionKey = sessionKey;
        }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemextra.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("iid", this.ItemId);
            parameters.Add("title", this.Title);
            parameters.Add("desc", this.Description);
            parameters.Add("feature", this.Feature);
            parameters.Add("memo", this.Memo);
            parameters.Add("type", this.Type);
            parameters.Add("reserve_price", this.ReservePrice);
            parameters.Add("sku_properties", this.SkuProperties);
            parameters.Add("sku_quantities", this.SkuQuantities);
            parameters.Add("sku_prices", this.SkuPrices);
            parameters.Add("sku_memos", this.SkuMemos);
            parameters.Add("sku_ids", this.SkuIds);
            parameters.Add("sku_extra_ids", this.SkuExtraIds);

            return parameters;
        }

        #endregion

        #region ITopPrivateRequest Members

        public string GetSessionKey()
        {
            return this.sessionKey;
        }

        #endregion
    }
}
