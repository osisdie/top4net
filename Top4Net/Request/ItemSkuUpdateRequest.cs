using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.sku.update
    /// </summary>
    public class ItemSkuUpdateRequest : ITopRequest
    {
        /// <summary>
        /// 商品的id。
        /// </summary>
        public string Iid { get; set; }

        /// <summary>
        /// Sku属性串，如pid:vid;pid1:vid1。
        /// </summary>
        public string Props { get; set; }

        /// <summary>
        /// Sku的库存数量。
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// Sku的销售价格。
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// Sku的商家外部id。
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// sku文字的版本，繁体传入zh_HK，简体传入zh_CN，不传默认为简体。
        /// </summary>
        public string Lang { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.sku.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("iid", this.Iid);
            parameters.Add("properties", this.Props);
            parameters.Add("quantity", this.Quantity);
            parameters.Add("price", this.Price);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("lang", this.Lang);

            return parameters;
        }

        #endregion
    }
}
