using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.joint.img
    /// </summary>
    public class ItemImgJointRequest : ITopRequest
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
        /// 商品图片地址。
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 商品图片位置。
        /// </summary>
        public Nullable<int> Position { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.joint.img";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("itemimg_id", this.ImgId);
            parameters.Add("iid", this.Iid);
            parameters.Add("position", this.Url);
            parameters.Add("url", this.Position);

            return parameters;
        }

        #endregion
    }
}
