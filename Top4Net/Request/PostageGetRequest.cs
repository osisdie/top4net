using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.postage.get
    /// </summary>
    public class PostageGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 模板编号。
        /// </summary>
        public string PostageId { get; set; }

        /// <summary>
        /// 卖家昵称。
        /// </summary>
        public string Nick { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.postage.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("postage_id", this.PostageId);
            parameters.Add("nick", this.Nick);

            return parameters;
        }

        #endregion
    }
}
