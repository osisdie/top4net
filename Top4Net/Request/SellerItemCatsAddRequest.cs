using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sellercats.list.add
    /// </summary>
    public class SellerItemCatsAddRequest : ITopPrivateRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 卖家自定义类目名称。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 链接图片地址。
        /// </summary>
        public string PictUrl { get; set; }

        /// <summary>
        /// 父类目ID。
        /// </summary>
        public string ParentCategoryId { get; set; }

        /// <summary>
        /// 该类目在页面上的排序位置。
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// 产品主图文件绝对地址。
        /// </summary>
        public string PrimaryPicPath { get; set; }

        public SellerItemCatsAddRequest(string sessionKey)
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
            return "taobao.sellercats.list.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("name", this.Name);
            parameters.Add("pict_url", this.PictUrl);
            parameters.Add("parent_cid", this.ParentCategoryId);
            parameters.Add("sort_order", this.SortOrder);

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
