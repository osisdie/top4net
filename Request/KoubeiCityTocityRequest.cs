using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.koubei.city.tocity
    /// </summary>
    public class KoubeiCityTocityRequest : ITopRequest<KoubeiCityTocityResponse>
    {
        /// <summary>
        /// 口碑的城市ID,优先根据ID取城市，再根据name取
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 城市名
        /// </summary>
        public string Name { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.koubei.city.tocity";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("name", this.Name);
            return parameters;
        }

        #endregion
    }
}
