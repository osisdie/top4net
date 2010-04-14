using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.add
    /// </summary>
    public class ProductAddRequest : ITopUploadRequest
    {
        public string Binds { get; set; }
        public Nullable<long> Cid { get; set; }
        public string CustomerProps { get; set; }
        public string Desc { get; set; }
        public FileItem Image { get; set; }
        public Nullable<bool> Major { get; set; }
        public string Name { get; set; }
        public string NativeUnKeyProps { get; set; }
        public string OuterId { get; set; }
        public string Price { get; set; }
        public string Props { get; set; }
        public string SaleProps { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("binds", this.Binds);
            parameters.Add("cid", this.Cid);
            parameters.Add("customer_props", this.CustomerProps);
            parameters.Add("desc", this.Desc);
            parameters.Add("major", this.Major);
            parameters.Add("name", this.Name);
            parameters.Add("nativeUnKeyProps", this.NativeUnKeyProps);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("price", this.Price);
            parameters.Add("props", this.Props);
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
