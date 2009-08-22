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
        /// 需要返回的字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 叶子类目编号。
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 属性和属性值编号串。
        /// </summary>
        public string Pvs { get; set; }

        /// <summary>
        /// 增量时间戳。
        /// </summary>
        public Nullable<DateTime> DateTime { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itempropvalues.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("fields", this.Fields);
            parameters.Add("cid", this.Cid);
            parameters.Add("pvs", this.Pvs);
            parameters.Add("datetime", this.DateTime);

            return parameters;
        }

        #endregion
    }
}
