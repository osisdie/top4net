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
        /// 图片ID字符串,可以一个也可以一组,用英文逗号间隔,如450,120,155。
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
