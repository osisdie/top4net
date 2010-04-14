using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.img.delete
    /// </summary>
    public class ProductImgDeleteRequest : ITopRequest
    {
        public Nullable<long> Id { get; set; }
        public Nullable<long> PicId { get; set; }
        public string ProductId { get; set; }
        public string V { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.img.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("pic_id", this.PicId);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("v", this.V);
            return parameters;
        }

        #endregion
    }
}
