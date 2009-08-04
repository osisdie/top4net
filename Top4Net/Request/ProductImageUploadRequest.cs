using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// 上传单张产品非主图。
    /// </summary>
    public class ProductImageUploadRequest : ITopUploadRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 产品图片编号。
        /// </summary>
        public string PicId { get; set; }

        /// <summary>
        /// 图片的绝对路径。
        /// </summary>
        public string PicPath { get; set; }

        /// <summary>
        /// 图片顺序编号。
        /// </summary>
        public int PicOrder { get; set; }

        /// <summary>
        /// 是否将该图片设为主图。
        /// </summary>
        public bool IsPrimary { get; set; }

        /// <summary>
        /// 产品编号。
        /// </summary>
        public string ProductId { get; set; }

        public ProductImageUploadRequest(string sessionKey)
        {
            if (string.IsNullOrEmpty(sessionKey))
            {
                throw new ArgumentNullException("sessionKey");
            }
            this.sessionKey = sessionKey;
        }

        #region ITopUploadRequest Members

        public IDictionary<string, string> GetFileParameters()
        {
            IDictionary<string, string> fileParams = new Dictionary<string, string>();
            fileParams.Add("image", this.PicPath);
            return fileParams;
        }

        #endregion

        #region ITopPrivateRequest Members

        public string GetSessionKey()
        {
            return this.sessionKey;
        }

        #endregion

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.img.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> textParams = new Dictionary<string, string>();

            textParams.Add("pic_id", this.PicId);
            textParams.Add("position", this.PicOrder + "");
            textParams.Add("is_major", this.IsPrimary + "");
            textParams.Add("product_id", this.ProductId);

            return textParams;
        }

        #endregion
    }
}
