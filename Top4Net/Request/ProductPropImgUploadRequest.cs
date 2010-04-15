using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.propimg.upload
    /// </summary>
    public class ProductPropimgUploadRequest : ITopUploadRequest
    {
        public Nullable<long> Id { get; set; }
        public FileItem Image { get; set; }
        public Nullable<int> Position { get; set; }
        public Nullable<long> ProductId { get; set; }
        public string Props { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.propimg.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("position", this.Position);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("props", this.Props);
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
