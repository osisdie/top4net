using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.warehouse.order.storeConsign
    /// </summary>
    public class WarehouseOrderStoreConsignRequest : ITopRequest<WarehouseOrderStoreConsignResponse>
    {
        /// <summary>
        /// 订单id
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 发货仓储 id 可以从接口taobao.warehouse.sellerstores.get中得到
        /// </summary>
        public string SellerStoreId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.warehouse.order.storeConsign";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("order_id", this.OrderId);
            parameters.Add("seller_store_id", this.SellerStoreId);
            return parameters;
        }

        #endregion
    }
}
