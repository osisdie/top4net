using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.delivery.cod.send
    /// </summary>
    public class DeliveryCodSendRequest : ITopRequest
    {
        public string CompanyCode { get; set; }
        public string FetcherAddress { get; set; }
        public Nullable<long> FetcherAreaId { get; set; }
        public string FetcherMobile { get; set; }
        public string FetcherName { get; set; }
        public string FetcherPhone { get; set; }
        public string FetcherZip { get; set; }
        public string Memo { get; set; }
        public string OrderType { get; set; }
        public string OutSid { get; set; }
        public string SellerAddress { get; set; }
        public Nullable<long> SellerAreaId { get; set; }
        public string SellerMobile { get; set; }
        public string SellerName { get; set; }
        public string SellerPhone { get; set; }
        public string SellerZip { get; set; }
        public Nullable<long> SessionUid { get; set; }
        public Nullable<long> Tid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.delivery.cod.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("company_code", this.CompanyCode);
            parameters.Add("fetcher_address", this.FetcherAddress);
            parameters.Add("fetcher_area_id", this.FetcherAreaId);
            parameters.Add("fetcher_mobile", this.FetcherMobile);
            parameters.Add("fetcher_name", this.FetcherName);
            parameters.Add("fetcher_phone", this.FetcherPhone);
            parameters.Add("fetcher_zip", this.FetcherZip);
            parameters.Add("memo", this.Memo);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("out_sid", this.OutSid);
            parameters.Add("seller_address", this.SellerAddress);
            parameters.Add("seller_area_id", this.SellerAreaId);
            parameters.Add("seller_mobile", this.SellerMobile);
            parameters.Add("seller_name", this.SellerName);
            parameters.Add("seller_phone", this.SellerPhone);
            parameters.Add("seller_zip", this.SellerZip);
            parameters.Add("session_uid", this.SessionUid);
            parameters.Add("tid", this.Tid);
            return parameters;
        }

        #endregion
    }
}
