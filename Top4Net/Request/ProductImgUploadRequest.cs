using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.img.upload
    /// </summary>
    public class ProductImgUploadRequest : ITopUploadRequest
    {
        public Nullable<long> Id { get; set; }
        public FileItem Image { get; set; }
        public string IsMajor { get; set; }
        public Nullable<int> Position { get; set; }
        public Nullable<long> ProductId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.img.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("is_major", this.IsMajor);
            parameters.Add("position", this.Position);
            parameters.Add("product_id", this.ProductId);
            return parameters;
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("image", this.Image);
            return parameters;
        }

        #endregion
    }
}
