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
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("cid", this.Cid);

            return parameters;
        }

        #endregion
    }
}
