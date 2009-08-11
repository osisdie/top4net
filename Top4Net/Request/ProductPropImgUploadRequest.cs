using System;
using System.IO;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.propimg.upload
    /// </summary>
    public class ProductPropImgUploadRequest : ITopUploadRequest
    {
        /// <summary>
        /// 产品属性图片编号。
        /// </summary>
        public string ImgId { get; set; }

        /// <summary>
        /// 产品编号。
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 属性串。
        /// </summary>
        public string Props { get; set; }

        /// <summary>
        /// 子图片文件。
        /// </summary>
        public FileInfo Image { get; set; }

        /// <summary>
        /// 图片序号。
        /// </summary>
        public int Position { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.propimg.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("pic_id", this.ImgId);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("props", this.Props);
            parameters.Add("position", this.Position + "");

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
