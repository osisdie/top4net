using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itempropvalues.get
    /// </summary>
    public class ItemPropValuesGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的字段(不包括is_parent)。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 叶子类目ID。
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 属性和属性值id串，格式pid:vid;pid:vid(pvs和datetime只传其中一个)。
        /// </summary>
        public string Pvs { get; set; }

        /// <summary>
        /// 增量时间戳，如果传1970-1-1 00:00:00，则取所有的属性和子属性值(状态为删除的属性值不返回prop_name)。
        /// </summary>
        public string Datetime { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itempropvalues.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("cid", this.Cid);
            parameters.Add("pvs", this.Pvs);
            parameters.Add("datetime", this.Datetime);

            return parameters;
        }

        #endregion
    }
}
