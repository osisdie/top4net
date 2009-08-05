using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemcats.list.get
    /// </summary>
    public class BuyerItemCatsGetRequest : ITopRequest
    {
        /// <summary>
        /// 父商品类目id，0表示根节点, 传输该参数返回所有子类目。 Cids和parent_cid至少传一个。
        /// </summary>
        public string ParentCategoryId { get; set; }

        /// <summary>
        /// 类目ID列表，用半角逗号(,)分隔，cids和parent_cid至少传一个。
        /// </summary>
        public string CategoryIds { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemcats.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("parent_cid", this.ParentCategoryId);
            parameters.Add("cids", this.CategoryIds);

            return parameters;
        }

        #endregion
    }
}
