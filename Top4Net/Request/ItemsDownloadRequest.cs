using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.items.download
    /// </summary>
    public class ItemsDownloadRequest : ITopRequest
    {
        /// <summary>
        /// 商品所属的店铺内卖家自定义类目。
        /// </summary>
        public string SellerCids { get; set; }

        /// <summary>
        /// 商品所属的类目编号。
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 匹配关键词。
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 在售(onsale)、仓库中(instock)、违规(irregular)。
        /// </summary>
        public string ApproveStatus { get; set; }

        /// <summary>
        /// 开始时间最小值。
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 开始时间最大值。
        /// </summary>
        public string EndDate { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.items.download";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("seller_cids", this.SellerCids);
            parameters.Add("cid", this.Cid);
            parameters.Add("q", this.Query);
            parameters.Add("approve_status", this.ApproveStatus);
            parameters.Add("start_date", this.StartDate);
            parameters.Add("end_date", this.EndDate);

            return parameters;
        }

        #endregion
    }
}
