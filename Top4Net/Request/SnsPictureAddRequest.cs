using System;
using System.IO;
using System.Collections.Generic;

using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sns.picture.add
    /// </summary>
    public class SnsPictureAddRequest : ITopUploadRequest
    {
        /// <summary>
        /// 用户图片。
        /// </summary>
        public FileItem Picture { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sns.picture.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            return parameters;
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("picture", this.Picture);
            return parameters;
        }

        #endregion
    }
}
