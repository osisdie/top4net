using System;
using System.IO;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.upload
    /// </summary>
    public class PictureUploadRequest : ITopUploadRequest
    {
        /// <summary>
        /// 图片分类编号。
        /// </summary>
        public string PicCategoryId { get; set; }

        /// <summary>
        /// 图片文件。
        /// </summary>
        public FileInfo Picture { get; set; }

        /// <summary>
        /// 包括后缀名的图片标题。
        /// </summary>
        public string LongTitle { get; set; }

        /// <summary>
        /// 不包含后缀名的图片标题。
        /// </summary>
        public string ShortTitle { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("picture_category_id", this.PicCategoryId);
            parameters.Add("image_input_title", this.LongTitle);
            parameters.Add("title", this.ShortTitle);

            return parameters;
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileInfo> GetFileParameters()
        {
            IDictionary<string, FileInfo> parameters = new Dictionary<string, FileInfo>();
            parameters.Add("img", this.Picture);
            return parameters;
        }

        #endregion
    }
}
