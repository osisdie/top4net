using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// KbListReview Data Structure.
    /// </summary>
    [Serializable]
    public class KbListReview : TopObject
    {
        /// <summary>
        /// 在店铺消费时的总人数
        /// </summary>
        [XmlElement("consum_num")]
        public long ConsumNum { get; set; }

        /// <summary>
        /// 在店铺的一次总消费
        /// </summary>
        [XmlElement("consum_total")]
        public long ConsumTotal { get; set; }

        /// <summary>
        /// 评论创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 店铺的环境氛围适合什么活动,例如:家庭聚会，随便吃吃,情侣约会,商务洽谈,朋友聚会,工作午餐,大型聚会.多个氛围以","为分割符
        /// </summary>
        [XmlElement("environments")]
        public string Environments { get; set; }

        /// <summary>
        /// 用户发表的文本评论
        /// </summary>
        [XmlElement("feeling")]
        public string Feeling { get; set; }

        /// <summary>
        /// 对店铺的印象,多个印象以","为分割符
        /// </summary>
        [XmlElement("impress")]
        public string Impress { get; set; }

        /// <summary>
        /// 对店铺的打分,1为差,2为中,3为好
        /// </summary>
        [XmlElement("rating")]
        public long Rating { get; set; }

        /// <summary>
        /// 对店铺的推荐菜,多个推荐以","为分割符
        /// </summary>
        [XmlElement("recommend")]
        public string Recommend { get; set; }

        /// <summary>
        /// 该条评论被回应的次数
        /// </summary>
        [XmlElement("reply_count")]
        public long ReplyCount { get; set; }

        /// <summary>
        /// UUID随机生成
        /// </summary>
        [XmlElement("review_id")]
        public string ReviewId { get; set; }

        /// <summary>
        /// 被评论对象的ID值
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 评论对象名
        /// </summary>
        [XmlElement("target_name")]
        public string TargetName { get; set; }

        /// <summary>
        /// 被评论对象的类型，被点评对象为店铺时target_type="1"
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 点评的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 评论修改时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 发表评论的用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [XmlElement("username")]
        public string Username { get; set; }
    }
}
