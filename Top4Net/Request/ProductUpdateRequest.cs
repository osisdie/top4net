using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.update
    /// </summary>
    public class ProductUpdateRequest : ITopRequest
    {
        public string Binds { get; set; }
        public string Desc { get; set; }
        public Nullable<bool> Major { get; set; }
        public string Name { get; set; }
        public string NativeUnkeyprops { get; set; }
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
            parameters.Add("native_unkeyprops", this.NativeUnkeyprops);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("price", this.Price);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("sale_props", this.SaleProps);
            return parameters;
        }

        #endregion
    }
}
