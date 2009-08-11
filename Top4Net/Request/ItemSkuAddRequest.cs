using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.sku.add
    /// </summary>
    public class ItemSkuAddRequest : ITopRequest
    {
        /// <summary>
        /// Sku所属商品编号。
        /// </summary>
        public string Iid { get; set; }

        /// <summary>
        /// Sku属性串。
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
        /// Sku的商家外部编号。
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// sku文字的版本。
        /// </summary>
        public string Language { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.sku.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("iid", this.Iid);
            parameters.Add("properties", this.Props);
            parameters.Add("quantity", this.Quantity);
            parameters.Add("price", this.Price);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("lang", this.Language);

            return parameters;
        }

        #endregion
    }
}
