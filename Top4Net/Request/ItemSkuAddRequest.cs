using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.sku.add
    /// </summary>
    public class ItemSkuAddRequest : ITopPrivateRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// Sku所属商品id。
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// Sku属性串,如：pid:vid;pid1:vid1…。
        /// </summary>
        public string Properties { get; set; }

        /// <summary>
        /// Sku的库存数量。
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// Sku的销售价格,商品的价格要在商品所有的sku的价格之间。
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

        /// <summary>
        /// 产品主图文件绝对地址。
        /// </summary>
        public string PrimaryPicPath { get; set; }

        public ItemSkuAddRequest(string sessionKey)
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
            return "taobao.item.sku.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("iid", this.ItemId);
            parameters.Add("properties", this.Properties);
            parameters.Add("quantity", this.Quantity);
            parameters.Add("price", this.Price);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("lang", this.Lang);

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
