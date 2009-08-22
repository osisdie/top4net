using System;
using System.IO;
using System.Collections.Generic;

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
        public FileInfo Picture { get; set; }

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

        public IDictionary<string, FileInfo> GetFileParameters()
        {
            IDictionary<string, FileInfo> parameters = new Dictionary<string, FileInfo>();
            parameters.Add("picture", this.Picture);
            return parameters;
        }

        #endregion
    }
}
