using System;
using System.Collections.Generic;
using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Request
{
    public class DynamicTopRequest : ITopUploadRequest
    {
        /// <summary>
        /// API名称。
        /// </summary>
        private string apiName;

        /// <summary>
        /// 文本参数。
        /// </summary>
        private TopDictionary textParams = new TopDictionary();

        /// <summary>
        /// 文件参数。
        /// </summary>
        private IDictionary<string, FileItem> fileParams = new Dictionary<string, FileItem>();

        public DynamicTopRequest(string apiName)
        {
            this.apiName = apiName;
        }

        public void AddTextParameter(string name, object value)
        {
            textParams.Add(name, value);
        }

        public void AddFileParameter(string name, FileItem file)
        {
            if (!string.IsNullOrEmpty(name) && file != null)
            {
                fileParams.Add(name, file);
            }
        }

        #region ITopUploadRequest Members

        #endregion

        #region ITopRequest Members

        public string GetApiName()
        {
            return this.apiName;
        }

        public IDictionary<string, string> GetParameters()
        {
            return this.textParams;
        }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return this.fileParams;
        }

        #endregion
    }
}
