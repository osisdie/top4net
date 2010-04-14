using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.ordersku.update
    /// </summary>
    public class TradeOrderskuUpdateRequest : ITopRequest
    {
        public Nullable<long> Oid { get; set; }
        public Nullable<long> SkuId { get; set; }
        public string SkuProps { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.ordersku.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("oid", this.Oid);
            parameters.Add("sku_id", this.SkuId);
            parameters.Add("sku_props", this.SkuProps);
            return parameters;
        }

        #endregion
    }
}
