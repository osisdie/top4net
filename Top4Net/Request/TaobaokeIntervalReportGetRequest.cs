using System;
using System.Collections.Generic;
using System.Text;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.interval.report.get
    /// add by icyker@gmail.com at 2010年6月19日18:24:22
    /// </summary>
    public class TaobaokeIntervalReportGetRequest : ITopRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.interval.report.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add( "start_date", this.StartDate.ToString( "yyyy-MM-dd HH:mm:ss" ) );
            parameters.Add( "end_date", this.EndDate.ToString( "yyyy-MM-dd HH:mm:ss" ) );
            return parameters;
        }

        #endregion
    }
}