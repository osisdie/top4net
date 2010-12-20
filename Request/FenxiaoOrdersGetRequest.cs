using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.orders.get
    /// </summary>
    public class FenxiaoOrdersGetRequest : ITopRequest<FenxiaoOrdersGetResponse>
    {
        /// <summary>
        /// 结束时间 格式 yyyy-MM-dd 起始时间与结束时间跨度为7天 。
        /// </summary>
        public Nullable<DateTime> EndCreated { get; set; }

        /// <summary>
        /// 页码。（大于0的整数。默认为1）
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数。（每页条数不超过50条）
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 采购单编号
        /// </summary>
        public Nullable<long> PurchaseOrderId { get; set; }

        /// <summary>
        /// 起始时间 格式 yyyy-MM-dd。
        /// </summary>
        public Nullable<DateTime> StartCreated { get; set; }

        /// <summary>
        /// 交易状态，不传默认查询所有采购单。可选值:        * WAIT_BUYER_PAY(等待买家付款)      * WAIT_SELLER_SEND_GOODS(等待卖家发货,即:买家已付款)      * WAIT_BUYER_CONFIRM_GOODS(等待买家确认收货,即:卖家已发货)      * TRADE_FINISHED(交易成功)      * TRADE_CLOSED(交易关闭)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 可选值：trade_time_type(采购单按照成交时间范围查询),update_time_type(采购单按照更新时间范围查询)
        /// </summary>
        public string TimeType { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.orders.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_created", this.EndCreated);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("purchase_order_id", this.PurchaseOrderId);
            parameters.Add("start_created", this.StartCreated);
            parameters.Add("status", this.Status);
            parameters.Add("time_type", this.TimeType);
            return parameters;
        }

        #endregion
    }
}
