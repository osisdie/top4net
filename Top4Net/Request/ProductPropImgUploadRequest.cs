using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.propimg.upload
    /// </summary>
    public class ProductPropImgUploadRequest : ITopUploadRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 产品属性图片ID。
        /// </summary>
        public string PicId { get; set; }

        /// <summary>
        /// 产品ID。
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 属性串，格式pid:vid，目前仅支持颜色属性。
        /// </summary>
        public string PropList { get; set; }

        /// <summary>
        /// 子图片，要先上传图片后再提交测试，否则图片不会被提交。
        /// </summary>
        public string PicPath { get; set; }

        /// <summary>
        /// 图片序号。
        /// </summary>
        public string PicOrder { get; set; }

        public ProductPropImgUploadRequest(string sessionKey)
        {
            if (string.IsNullOrEmpty(sessionKey))
            {
                throw new ArgumentNullException("sessionKey");
            }
            this.sessionKey = sessionKey;
        }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.propimg.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("pic_id", this.PicId);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("props", this.PropList);
            parameters.Add("position", this.PicOrder);

            return parameters;
        }

        #endregion

        #region ITopPrivateRequest Members

        public string GetSessionKey()
        {
            return this.sessionKey;
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, string> GetFileParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("image", this.PicPath);

            return parameters;
        }

        #endregion
    }
}
