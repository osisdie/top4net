using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.price.update
    /// </summary>
    public class TradePriceUpdateRequest : ITopRequest
    {
        public string AdjustFees { get; set; }
        public string CertSign { get; set; }
        public string LogisticsFee { get; set; }
        public string Oids { get; set; }
        public string OriginFees { get; set; }
        public Nullable<long> Tid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.price.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("adjust_fees", this.AdjustFees);
            parameters.Add("cert_sign", this.CertSign);
            parameters.Add("logistics_fee", this.LogisticsFee);
            parameters.Add("oids", this.Oids);
            parameters.Add("origin_fees", this.OriginFees);
            parameters.Add("tid", this.Tid);
            return parameters;
        }

        #endregion
    }
}
