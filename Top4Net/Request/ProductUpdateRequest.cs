using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.update
    /// </summary>
    public class ProductUpdateRequest : ITopUploadRequest
    {
        public string Binds { get; set; }
        public string Desc { get; set; }
        public FileItem Image { get; set; }
        public Nullable<bool> Major { get; set; }
        public string Name { get; set; }
        public string NativeUnKeyProps { get; set; }
        public string OuterId { get; set; }
        public string Price { get; set; }
        public Nullable<long> ProductId { get; set; }
        public string SaleProps { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("binds", this.Binds);
            parameters.Add("desc", this.Desc);
            parameters.Add("major", this.Major);
            parameters.Add("name", this.Name);
            parameters.Add("nativeUnKeyProps", this.NativeUnKeyProps);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("price", this.Price);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("sale_props", this.SaleProps);
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
