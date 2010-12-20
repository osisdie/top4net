using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wangwang.eservice.avgwaittime.get
    /// </summary>
    public class WangwangEserviceAvgwaittimeGetRequest : ITopRequest<WangwangEserviceAvgwaittimeGetResponse>
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        public Nullable<DateTime> EndDate { get; set; }

        /// <summary>
        /// 客服人员id：cntaobao+淘宝nick，例如cntaobaotest
        /// </summary>
        public string ServiceStaffId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public Nullable<DateTime> StartDate { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wangwang.eservice.avgwaittime.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_date", this.EndDate);
            parameters.Add("service_staff_id", this.ServiceStaffId);
            parameters.Add("start_date", this.StartDate);
            return parameters;
        }

        #endregion
    }
}
