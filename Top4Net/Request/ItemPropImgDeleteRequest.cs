using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.propimg.delete
    /// </summary>
    public class ItemPropImgDeleteRequest : ITopRequest
    {
        /// <summary>
        /// 商品图片ID。
        /// </summary>
        public string ImgId { get; set; }

        /// <summary>
        /// 商品ID。
        /// </summary>
        public string Iid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.propimg.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("propimg_id", this.ImgId);
            parameters.Add("iid", this.Iid);

            return parameters;
        }

        #endregion
    }
}
