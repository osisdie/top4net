using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemprops.list.get
    /// </summary>
    public class ItemPropsListRequest : ITopRequest
    {
        /// <summary>
        /// 叶子类目编号
        /// </summary>
        public string Cid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemprops.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("cid", this.Cid);

            return parameters;
        }

        #endregion
    }
}
