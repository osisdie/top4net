using System;
using System.IO;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.propimg.upload
    /// </summary>
    public class ItemPropImgUploadRequest : ITopUploadRequest
    {
        /// <summary>
        /// 属性图片ID,如果是新增不需要填写。
        /// </summary>
        public string ImgId { get; set; }

        /// <summary>
        /// 商品ID。
        /// </summary>
        public string Iid { get; set; }

        /// <summary>
        /// 属性图片属性串pid:vid;pid1:vid1。
        /// </summary>
        public string Props { get; set; }

        /// <summary>
        /// 属性图片位置。
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 属性图片内容，要先上传图片后再提交测试，否则图片不会被提交。
        /// </summary>
        public FileInfo Image { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.propimg.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("propimg_id", this.ImgId);
            parameters.Add("iid", this.Iid);
            parameters.Add("properties", this.Props);
            parameters.Add("position", this.Position);

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
