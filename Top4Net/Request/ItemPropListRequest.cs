using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemprop.list.get
    /// </summary>
    public class ItemPropListRequest : ITopRequest
    {
        /// <summary>
        /// 叶子类目编号
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 类目属性编号
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 类目子属性路径
        /// </summary>
        public string ChildPropPath { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemprop.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("cid", this.Cid);
            parameters.Add("pid", this.Pid);
            parameters.Add("child_path", this.ChildPropPath);

            return parameters;
        }

        #endregion
    }
}
