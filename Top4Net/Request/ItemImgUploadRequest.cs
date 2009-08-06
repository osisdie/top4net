using System;
using System.IO;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.img.upload
    /// </summary>
    public class ItemImgUploadRequest : ITopUploadRequest
    {
        /// <summary>
        /// 商品图片id(如果是更新图片，则需要传该参数)。
        /// </summary>
        public string ItemImgId { get; set; }

        /// <summary>
        /// 商品ID。
        /// </summary>
        public string Iid { get; set; }

        /// <summary>
        /// 商品图片位置。
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 商品图片内容(更新图片其他信息时可以不传)，要先上传图片后再提交测试，否则图片不会被提交。
        /// </summary>
        public FileInfo Image { get; set; }

        /// <summary>
        /// 是否将该图片设为主图(默认为false)。
        /// </summary>
        public string IsPrimary { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.img.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("itemimg_id", this.ItemImgId);
            parameters.Add("iid", this.Iid);
            parameters.Add("position", this.Position);
            parameters.Add("is_major", this.IsPrimary);

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
