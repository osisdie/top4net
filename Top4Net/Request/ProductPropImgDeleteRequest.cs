using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.propimg.delete
    /// </summary>
    public class ProductPropImgDeleteRequest : ITopRequest
    {
        /// <summary>
        /// 产品属性图片编号。
        /// </summary>
        public string ImgId { get; set; }

        /// <summary>
        /// 产品编号。
        /// </summary>
        public string ProductId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.propimg.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("pic_id", this.ImgId);
            parameters.Add("product_id", this.ProductId);

            return parameters;
        }

        #endregion
    }
}
