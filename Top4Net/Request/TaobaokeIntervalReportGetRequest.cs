using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.interval.report.get
    /// </summary>
    public class TaobaokeIntervalReportGetRequest : ITopRequest
    {
        public string EndDate { get; set; }
        public string Fields { get; set; }
        public string StartDate { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.interval.report.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_date", this.EndDate);
            parameters.Add("fields", this.Fields);
            parameters.Add("start_date", this.StartDate);
            return parameters;
        }

        #endregion
    }
}
