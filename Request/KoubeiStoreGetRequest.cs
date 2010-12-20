using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.koubei.store.get
    /// </summary>
    public class KoubeiStoreGetRequest : ITopRequest<KoubeiStoreGetResponse>
    {
        /// <summary>
        /// 城市id
        /// </summary>
        public Nullable<long> CityId { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        public string StoreId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.koubei.store.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("city_id", this.CityId);
            parameters.Add("store_id", this.StoreId);
            return parameters;
        }

        #endregion
    }
}
