using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.img.delete
    /// </summary>
    public class ItemImgDeleteRequest : ITopRequest
    {
        /// <summary>
        /// 商品图片编号。
        /// </summary>
        public string ImgId { get; set; }

        /// <summary>
        /// 商品编号。
        /// </summary>
        public string Iid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.img.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("itemimg_id", this.ImgId);
            parameters.Add("iid", this.Iid);

            return parameters;
        }

        #endregion
    }
}
