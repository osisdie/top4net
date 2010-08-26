using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.open.add
    /// </summary>
    public class TradeOpenAddRequest : ITopRequest
    {
        public string BuyerMessage { get; set; }
        public Nullable<bool> DecreaseStock { get; set; }
        public string DiscountFees { get; set; }
        public string LogisticsFee { get; set; }
        public string LogisticsType { get; set; }
        public string NumIids { get; set; }
        public string Nums { get; set; }
        public string PayTitle { get; set; }
        public string Promotion { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverCity { get; set; }
        public string ReceiverDistrict { get; set; }
        public string ReceiverMobile { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string ReceiverState { get; set; }
        public string ReceiverZip { get; set; }
        public string SkuIds { get; set; }
        public string TradeMemo { get; set; }
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.open.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_message", this.BuyerMessage);
            parameters.Add("decrease_stock", this.DecreaseStock);
            parameters.Add("discount_fees", this.DiscountFees);
            parameters.Add("logistics_fee", this.LogisticsFee);
            parameters.Add("logistics_type", this.LogisticsType);
            parameters.Add("num_iids", this.NumIids);
            parameters.Add("nums", this.Nums);
            parameters.Add("pay_title", this.PayTitle);
            parameters.Add("promotion", this.Promotion);
            parameters.Add("receiver_address", this.ReceiverAddress);
            parameters.Add("receiver_city", this.ReceiverCity);
            parameters.Add("receiver_district", this.ReceiverDistrict);
            parameters.Add("receiver_mobile", this.ReceiverMobile);
            parameters.Add("receiver_name", this.ReceiverName);
            parameters.Add("receiver_phone", this.ReceiverPhone);
            parameters.Add("receiver_state", this.ReceiverState);
            parameters.Add("receiver_zip", this.ReceiverZip);
            parameters.Add("sku_ids", this.SkuIds);
            parameters.Add("trade_memo", this.TradeMemo);
            parameters.Add("type", this.Type);
            return parameters;
        }

        #endregion
    }
}
