using System;
using System.IO;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.update
    /// </summary>
    public class ProductUpdateRequest : ITopUploadRequest
    {
        /// <summary>
        /// 产品编号。
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 外部产品编号。
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 绑定属性。
        /// </summary>
        public string BindProps { get; set; }

        /// <summary>
        /// 销售属性。
        /// </summary>
        public string SaleProps { get; set; }

        /// <summary>
        /// 产品名称。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 产品市场价。
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 产品描述。
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 产品主图文件。
        /// </summary>
        public FileInfo Image { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("product_id", this.ProductId);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("binds", this.BindProps);
            parameters.Add("sale_props", this.SaleProps);
            parameters.Add("name", this.Name);
            parameters.Add("price", this.Price);
            parameters.Add("desc", this.Desc);

            return parameters;
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileInfo> GetFileParameters()
        {
            IDictionary<string, FileInfo> parameters = new Dictionary<string, FileInfo>();
            parameters.Add("image", this.Image);
            return parameters;
        }

        #endregion
    }
}
