using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.delete
    /// </summary>
    public class PictureDeleteRequest : ITopRequest
    {
        /// <summary>
        /// 图片编号字符串。
        /// </summary>
        public string PicIds { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("picture_ids", this.PicIds);

            return parameters;
        }

        #endregion
    }
}
