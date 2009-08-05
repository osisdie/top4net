using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.propimg.upload
    /// </summary>
    public class ItemPropImgUploadRequest : ITopUploadRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 属性图片ID,如果是新增不需要填写。
        /// </summary>
        public string PropPicId { get; set; }

        /// <summary>
        /// 商品ID。
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// 属性图片属性串pid:vid;pid1:vid1。
        /// </summary>
        public string Properties { get; set; }

        /// <summary>
        /// 属性图片位置。
        /// </summary>
        public string PicOrder { get; set; }

        /// <summary>
        /// 属性图片内容，要先上传图片后再提交测试，否则图片不会被提交。
        /// </summary>
        public string PicPath { get; set; }

        public ItemPropImgUploadRequest(string sessionKey)
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
            return "taobao.item.propimg.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("propimg_id", this.PropPicId);
            parameters.Add("iid", this.ItemId);
            parameters.Add("properties", this.Properties);
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
