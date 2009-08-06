using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.user.get
    /// </summary>
    public class UserGetRequest : ITopRequest
    {
        /// <summary>
        /// User数据结构字段列表，以半角逗号(,)分隔。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 用户昵称。
        /// </summary>
        public string Nick { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.user.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("nick", this.Nick);

            return parameters;
        }

        #endregion
    }
}
