using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.img.delete
    /// </summary>
    public class ProductImgDeleteRequest : ITopRequest
    {
        /// <summary>
        /// 产品多图图片编号。
        /// </summary>
        public string ImgId { get; set; }

        /// <summary>
        /// 产品编号。
        /// </summary>
        public string ProductId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.img.delete";
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
