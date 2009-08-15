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
        /// 商品的编号。
        /// </summary>
        public string Iid { get; set; }

        /// <summary>
        /// SKU属性串。
        /// </summary>
        public string Props { get; set; }

        /// <summary>
        /// SKU的库存数量。
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// SKU的销售价格。
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// SKU的商家外部编号。
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// SKU文字的版本。
        /// </summary>
        public string Language { get; set; }

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
            parameters.Add("quantity", this.Quantity + "");
            parameters.Add("price", this.Price);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("lang", this.Language);

            return parameters;
        }

        #endregion
    }
}
