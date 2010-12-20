using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.koubei.review.search
    /// </summary>
    public class KoubeiReviewSearchRequest : ITopRequest<KoubeiReviewSearchResponse>
    {
        /// <summary>
        /// 列表翻页用的页码，大于0的整数，默认为1,最大值：50
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数，大于0的整数，默认为20，最大值：80
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 评论对象的id
        /// </summary>
        public string TargetId { get; set; }

        /// <summary>
        /// 被评论对象的类型，店铺对象类型为“1”,目前就支持这个
        /// </summary>
        public string TargetType { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.koubei.review.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("target_id", this.TargetId);
            parameters.Add("target_type", this.TargetType);
            return parameters;
        }

        #endregion
    }
}
