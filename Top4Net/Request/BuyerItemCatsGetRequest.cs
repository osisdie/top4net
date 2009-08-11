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
        /// 父商品类目编号
        /// </summary>
        public string ParentCid { get; set; }

        /// <summary>
        /// 类目编号列表
        /// </summary>
        public string Cids { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemcats.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("parent_cid", this.ParentCid);
            parameters.Add("cids", this.Cids);

            return parameters;
        }

        #endregion
    }
}
