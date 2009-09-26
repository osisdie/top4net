using System;
using System.IO;
using System.Collections.Generic;
using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.img.upload
    /// </summary>
    public class ItemImgUploadRequest : ITopUploadRequest
    {
        /// <summary>
        /// 商品图片编号。
        /// </summary>
        public string ImgId { get; set; }

        /// <summary>
        /// 商品编号。
        /// </summary>
        public string Iid { get; set; }

        /// <summary>
        /// 商品图片位置。
        /// </summary>
        public Nullable<int> Position { get; set; }

        /// <summary>
        /// 商品图片内容。
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 是否将该图片设为主图。
        /// </summary>
        public Nullable<bool> IsPrimary { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.img.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("itemimg_id", this.ImgId);
            parameters.Add("iid", this.Iid);
            parameters.Add("position", this.Position);
            parameters.Add("is_major", this.IsPrimary);

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
