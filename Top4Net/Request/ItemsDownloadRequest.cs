using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.items.download
    /// </summary>
    public class ItemsDownloadRequest : ITopPrivateRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 商品所属的店铺内卖家自定义类目。
        /// </summary>
        public string SellerCids { get; set; }

        /// <summary>
        /// 商品所属的类目ID。
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// 匹配关键词(匹配title)。
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

        /// <summary>
        /// 产品主图文件绝对地址。
        /// </summary>
        public string PrimaryPicPath { get; set; }

        public ItemsDownloadRequest(string sessionKey)
        {
            if (string.IsNullOrEmpty(sessionKey))
            {
                throw new ArgumentNullException("sessionKey");
            }
            this.sessionKey = sessionKey;
        }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.items.download";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("seller_cids", this.SellerCids);
            parameters.Add("cid", this.CategoryId);
            parameters.Add("q", this.Query);
            parameters.Add("approve_status", this.ApproveStatus);
            parameters.Add("start_date", this.StartDate);
            parameters.Add("end_date", this.EndDate);

            return parameters;
        }

        #endregion

        #region ITopPrivateRequest Members

        public string GetSessionKey()
        {
            return this.sessionKey;
        }

        #endregion
    }
}
