using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.report.get
    /// </summary>
    public class TaobaokeReportGetRequest : ITopRequest
    {
        /// <summary>
        /// 需返回的字段列表。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 需要查询报表的日期。
        /// </summary>
        public string Date { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.report.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("fields", this.Fields);
            parameters.Add("date", this.Date);

            return parameters;
        }

        #endregion
    }
}
