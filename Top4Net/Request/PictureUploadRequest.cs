using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.upload
    /// </summary>
    public class PictureUploadRequest : ITopUploadRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 图片分类ID，具体某个分类ID或0上传到未分类下，只能一个分类。
        /// </summary>
        public string PictureCategoryId { get; set; }

        /// <summary>
        /// 图片,允许png、jpg、gif图片格式。
        /// </summary>
        public string Img { get; set; }

        /// <summary>
        /// 包括后缀名的图片标题,不能为空，如Bule.jpg,有些卖家希望图片上传后取图片文件的默认名。
        /// </summary>
        public string ImageInputTitle { get; set; }

        /// <summary>
        /// 图片标题,如果为空,传的图片标题就取去掉后缀名的image_input_title,超过50字符长度会截取50字符,重名会在标题末尾加(1);标题末尾已经有(数字)了，则数字加1。
        /// </summary>
        public string Title { get; set; }

        public PictureUploadRequest(string sessionKey)
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
            return "taobao.picture.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("picture_category_id", this.PictureCategoryId);
            parameters.Add("image_input_title", this.ImageInputTitle);
            parameters.Add("title", this.Title);

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

            parameters.Add("img", this.Img);

            return parameters;
        }

        #endregion
    }
}
