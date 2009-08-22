using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.shippings.send.get
    /// </summary>
    public class LogisticsOrderGetRequest : ITopRequest
    {
        /// <summary>
        /// 查询字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 交易编号。
        /// </summary>
        public string Tid { get; set; }

        /// <summary>
        /// 买家昵称。
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 物流状态。
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 卖家是否发货。
        /// </summary>
        public string SellerConfirm { get; set; }

        /// <summary>
        /// 收货人姓名。
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// 创建时间开始。
        /// </summary>
        public Nullable<DateTime> StartCreated { get; set; }

        /// <summary>
        /// 创建时间结束。
        /// </summary>
        public Nullable<DateTime> EndCreated { get; set; }

        /// <summary>
        /// 谁承担运费。
        /// </summary>
        public string FreightPayer { get; set; }

        /// <summary>
        /// 平邮(post) 快递(express) EMS(ems)。
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public Nullable<int> PageNo { get; set; }

        /// <summary>
        /// 每页条数。
        /// </summary>
        public Nullable<int> PageSize { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.shippings.send.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("fields", this.Fields);
            parameters.Add("tid", this.Tid);
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("status", this.Status);
            parameters.Add("seller_confirm", this.SellerConfirm);
            parameters.Add("receiver_name", this.ReceiverName);
            parameters.Add("start_created", this.StartCreated);
            parameters.Add("end_created", this.EndCreated);
            parameters.Add("freight_payer", this.FreightPayer);
            parameters.Add("type", this.Type);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);

            return parameters;
        }

        #endregion
    }
}
