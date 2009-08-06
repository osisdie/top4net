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
        /// 需返回的字段列表.可选值:TaobaokeReportMember淘宝客报表成员结构体中的所有字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 需要查询报表的日期，有效的日期为最近3个月内的某一天，格式为:yyyyMMdd,如20090520。
        /// </summary>
        public string Date { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.report.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("date", this.Date);

            return parameters;
        }

        #endregion
    }
}
