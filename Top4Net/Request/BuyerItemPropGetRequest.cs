using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemprop.list.get
    /// </summary>
    public class BuyerItemPropGetRequest : ITopRequest
    {
        /// <summary>
        /// 叶子类目编号
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 类目属性编号，取类目属性需要传cid和pid。
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 类目子属性路径,由该子属性上层的类目属性和类目属性值组成,格式pid:vid;pid:vid.取类目子属性需要传child_path,cid。
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
