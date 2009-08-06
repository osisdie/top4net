using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sns.picture.setUsed
    /// </summary>
    public class SnsPictureUseRequest : ITopRequest
    {
        /// <summary>
        /// 图片文件ids，例如：value1,value2,value3。
        /// </summary>
        public string Ids { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sns.picture.setUsed";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("ids", this.Ids);

            return parameters;
        }

        #endregion
    }
}
