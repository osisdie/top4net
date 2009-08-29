using System;
using System.Collections.Generic;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.nbsadd
    /// </summary>
    public class TradeAddRequest : ITopRequest
    {
        /// <summary>
        /// 商品编号列表。
        /// </summary>
        public string Iids { get; set; }

        /// <summary>
        /// 商品销售属性列表。
        /// </summary>
        public string SkuIds { get; set; }

        /// <summary>
        /// 商品价格列表。
        /// </summary>
        public string Prices { get; set; }

        /// <summary>
        /// 商品购买数量列表。
        /// </summary>
        public string Nums { get; set; }

        /// <summary>
        /// 商品标题列表。
        /// </summary>
        public string Titles { get; set; }

        /// <summary>
        /// 订单备注列表。
        /// </summary>
        public string Memos { get; set; }

        /// <summary>
        /// 商品折扣金额列表。
        /// </summary>
        public string DiscountFees { get; set; }

        /// <summary>
        /// 支付标题。
        /// </summary>
        public string PayTitle { get; set; }

        /// <summary>
        /// 卖家昵称。
        /// </summary>
        public string SellerNick { get; set; }

        /// <summary>
        /// 买家昵称。
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 买家留言。
        /// </summary>
        public string BuyerMessage { get; set; }

        /// <summary>
        /// 交易类型。
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 交易快照信息。
        /// </summary>
        public string Snapshot { get; set; }

        /// <summary>
        /// 地区代号。
        /// </summary>
        public string AreaCode { get; set; }

        /// <summary>
        /// 物流方式。
        /// </summary>
        public string LogisticsType { get; set; }

        /// <summary>
        /// 物流费用。
        /// </summary>
        public string LogisticsFee { get; set; }

        /// <summary>
        /// 地址信息。
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// 是否保存收货地址。
        /// </summary>
        public Nullable<bool> SaveDeliverAddress { get; set; }

        /// <summary>
        /// 收货人全名。
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// 固定电话号码。
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 移动电话号码。
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 店铺促销信息。
        /// </summary>
        public string ShopPromotion { get; set; }

        /// <summary>
        /// 子订单快照信息。
        /// </summary>
        public IDictionary<string, string> OrderSnapshots { get; set; }

        /// <summary>
        /// 套餐信息。
        /// </summary>
        public IDictionary<string, string> ItemMeals { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.nbsadd";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("iids", this.Iids);
            parameters.Add("prices", this.Prices);
            parameters.Add("nums", this.Nums);
            parameters.Add("sku_ids", this.SkuIds);
            parameters.Add("titles", this.Titles);
            parameters.Add("order_memos", this.Memos);
            parameters.Add("discount_fees", this.DiscountFees);
            parameters.Add("pay_title", this.PayTitle);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("buyer_message", this.BuyerMessage);
            parameters.Add("type", this.Type);
            parameters.Add("snapshot", this.Snapshot);
            parameters.Add("division_code", this.AreaCode);
            parameters.Add("post_fee", this.LogisticsFee);
            parameters.Add("logistic.type", this.LogisticsType);
            parameters.Add("save_deliver_addr", this.SaveDeliverAddress);

            if (this.Location != null)
            {
                parameters.Add("location.zip", this.Location.Zip);
                parameters.Add("location.address", this.Location.Address);
                parameters.Add("location.state", this.Location.State);
                parameters.Add("location.city", this.Location.City);
                parameters.Add("location.district", this.Location.District);
            }

            parameters.Add("receiver_name", this.ReceiverName);
            parameters.Add("shop_promotion", this.ShopPromotion);
            parameters.Add("phone", this.Phone);
            parameters.Add("mobile", this.Mobile);

            if (this.OrderSnapshots != null)
            {
                IEnumerator<KeyValuePair<string, string>> osEnum = this.OrderSnapshots.GetEnumerator();
                while (osEnum.MoveNext())
                {
                    parameters.Add(osEnum.Current.Key, osEnum.Current.Value);
                }
            }

            if (this.ItemMeals != null)
            {
                IEnumerator<KeyValuePair<string, string>> imEnum = this.ItemMeals.GetEnumerator();
                while (imEnum.MoveNext())
                {
                    parameters.Add(imEnum.Current.Key, imEnum.Current.Value);
                }
            }

            return parameters;
        }

        #endregion
    }
}
