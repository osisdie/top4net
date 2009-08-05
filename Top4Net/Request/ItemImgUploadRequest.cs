using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.img.upload
    /// </summary>
    public class ItemImgUploadRequest : ITopUploadRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 商品图片id(如果是更新图片，则需要传该参数)。
        /// </summary>
        public string ItemimgId { get; set; }

        /// <summary>
        /// 商品ID。
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// 商品图片位置。
        /// </summary>
        public string PicOrder { get; set; }

        /// <summary>
        /// 商品图片内容(更新图片其他信息时可以不传)，要先上传图片后再提交测试，否则图片不会被提交。
        /// </summary>
        public string PicPath { get; set; }

        /// <summary>
        /// 是否将该图片设为主图(默认为false)。
        /// </summary>
        public string IsPrimary { get; set; }

        public ItemImgUploadRequest(string sessionKey)
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
            return "taobao.item.img.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("itemimg_id", this.ItemimgId);
            parameters.Add("iid", this.ItemId);
            parameters.Add("position", this.PicOrder);
            parameters.Add("is_major", this.IsPrimary);

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
