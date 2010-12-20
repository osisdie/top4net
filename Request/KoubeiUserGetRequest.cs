using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.koubei.user.get
    /// </summary>
    public class KoubeiUserGetRequest : ITopRequest<KoubeiUserGetResponse>
    {
        /// <summary>
        /// 会员的ID号
        /// </summary>
        public string UserId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.koubei.user.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
