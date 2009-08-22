using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.postage.delete
    /// </summary>
    public class PostageDeleteRequest : ITopRequest
    {
        /// <summary>
        /// 邮费模板编号。
        /// </summary>
        public string PostageId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.postage.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("postage_id", this.PostageId);
            return parameters;
        }

        #endregion
    }
}
