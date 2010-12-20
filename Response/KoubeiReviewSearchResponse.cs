using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// KoubeiReviewSearchResponse.
    /// </summary>
    public class KoubeiReviewSearchResponse : TopResponse
    {
        /// <summary>
        /// 评论列表对象
        /// </summary>
        [XmlArray("kb_list_reviews")]
        [XmlArrayItem("kb_list_review")]
        public List<KbListReview> KbListReviews { get; set; }

        /// <summary>
        /// 返回的点评总数，如：500，可以用于翻页时计算总页数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
