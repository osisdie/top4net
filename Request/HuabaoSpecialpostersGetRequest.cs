using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.huabao.specialposters.get
    /// </summary>
    public class HuabaoSpecialpostersGetRequest : ITopRequest<HuabaoSpecialpostersGetResponse>
    {
        /// <summary>
        /// 频道Id
        /// </summary>
        public string ChannelIds { get; set; }

        /// <summary>
        /// 返回的记录数，默认10条，最多20条，如果请求超过20或者小于等于0，则按10条返回
        /// </summary>
        public Nullable<long> Number { get; set; }

        /// <summary>
        /// 类型可选：HOT(热门），RECOMMEND（推荐）
        /// </summary>
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.huabao.specialposters.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel_ids", this.ChannelIds);
            parameters.Add("number", this.Number);
            parameters.Add("type", this.Type);
            return parameters;
        }

        #endregion
    }
}
