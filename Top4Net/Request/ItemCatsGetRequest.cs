using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemcats.get.v2
    /// </summary>
    public class ItemCatsGetRequest : ITopPrivateRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 需要返回的字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 父商品类目id，0表示根节点, 传输该参数返回所有子类目。 Cids、parent_cid至少传一个。
        /// </summary>
        public string ParentCategoryId { get; set; }

        /// <summary>
        /// 类目ID列表，用半角逗号(,)分隔。
        /// </summary>
        public string CategoryIds { get; set; }

        /// <summary>
        /// 时间戳，如果没有传，则取所有的类目信息(如果传了parent_cid或者cids，则忽略datetime)。
        /// </summary>
        public string Datetime { get; set; }

        /// <summary>
        /// 产品主图文件绝对地址。
        /// </summary>
        public string PrimaryPicPath { get; set; }

        public ItemCatsGetRequest(string sessionKey)
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
            return "taobao.itemcats.get.v2";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("parent_cid", this.ParentCategoryId);
            parameters.Add("cids", this.CategoryIds);
            parameters.Add("datetime", this.Datetime);

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
