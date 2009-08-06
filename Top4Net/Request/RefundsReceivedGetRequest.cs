using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.refunds.receive.get
    /// </summary>
    public class RefundsReceivedGetRequest : ITopRequest
    {
        /// <summary>
        /// 退款状态。
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 买家昵称。
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public string PageNo { get; set; }

        /// <summary>
        /// 每页条数 (每页返回最多返回100条,默认值为20)。
        /// </summary>
        public string PageSize { get; set; }

        /// <summary>
        /// 需要返回的字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// guarantee_trade,一口价、拍卖,auto_delivery,自动发货,independent_shop_trade,外部网店的交易。
        /// </summary>
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.refunds.receive.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("status", this.Status);
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("fields", this.Fields);
            parameters.Add("type", this.Type);

            return parameters;
        }

        #endregion
    }
}
