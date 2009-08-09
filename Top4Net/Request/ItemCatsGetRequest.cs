using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemcats.get.v2
    /// </summary>
    public class ItemCatsGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 类目ID列表，用半角逗号(,)分隔。
        /// </summary>
        public string Cids { get; set; }

        /// <summary>
        /// 父商品类目编号，0表示根节点, 传输该参数返回所有子类目。 cids、parent_cid至少传一个。
        /// </summary>
        public string ParentCid { get; set; }

        /// <summary>
        /// 时间戳，如果没有传，则取所有的类目信息(如果传了parent_cid或者cids，则忽略datetime)。
        /// </summary>
        public string DateTime { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemcats.get.v2";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("parent_cid", this.ParentCid);
            parameters.Add("cids", this.Cids);
            parameters.Add("datetime", this.DateTime);

            return parameters;
        }

        #endregion
    }
}
