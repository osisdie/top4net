using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.koubei.store.categories.get
    /// </summary>
    public class KoubeiStoreCategoriesGetRequest : ITopRequest<KoubeiStoreCategoriesGetResponse>
    {
        /// <summary>
        /// 类目id，根类目id为0
        /// </summary>
        public Nullable<long> CateId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.koubei.store.categories.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cate_id", this.CateId);
            return parameters;
        }

        #endregion
    }
}
