using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.koubei.city.subs.get
    /// </summary>
    public class KoubeiCitySubsGetRequest : ITopRequest<KoubeiCitySubsGetResponse>
    {
        /// <summary>
        /// 口碑的城市ID
        /// </summary>
        public Nullable<long> Id { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.koubei.city.subs.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            return parameters;
        }

        #endregion
    }
}
