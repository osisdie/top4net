using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// KbDetailStore Data Structure.
    /// </summary>
    [Serializable]
    public class KbDetailStore : TopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 点评总数
        /// </summary>
        [XmlElement("appraisement_count")]
        public long AppraisementCount { get; set; }

        /// <summary>
        /// 主类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 城市名
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 是否推荐
        /// </summary>
        [XmlElement("commend")]
        public bool Commend { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 网店的detail网址
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// UUID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 店铺介绍
        /// </summary>
        [XmlElement("introduce")]
        public string Introduce { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 店名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 其他联系人信息
        /// </summary>
        [XmlElement("other_contact")]
        public string OtherContact { get; set; }

        /// <summary>
        /// 是否店主
        /// </summary>
        [XmlElement("owner")]
        public bool Owner { get; set; }

        /// <summary>
        /// 人均消费价格,浮点
        /// </summary>
        [XmlElement("per_consumption_price")]
        public string PerConsumptionPrice { get; set; }

        /// <summary>
        /// 电话,如果多个就以逗号分隔
        /// </summary>
        [XmlElement("phones")]
        public string Phones { get; set; }

        /// <summary>
        /// 店铺图片,绝对路径,多张已逗号分隔
        /// </summary>
        [XmlElement("pictures")]
        public string Pictures { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [XmlElement("post_time")]
        public string PostTime { get; set; }

        /// <summary>
        /// 产品图片,绝对路径,多个图片以逗号分隔
        /// </summary>
        [XmlElement("products")]
        public string Products { get; set; }

        /// <summary>
        /// 推荐排名
        /// </summary>
        [XmlElement("recommend_order")]
        public long RecommendOrder { get; set; }

        /// <summary>
        /// 分店名
        /// </summary>
        [XmlElement("subname")]
        public string Subname { get; set; }

        /// <summary>
        /// 店铺自己的主页网址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 登记人用户名
        /// </summary>
        [XmlElement("username")]
        public string Username { get; set; }

        /// <summary>
        /// 人气
        /// </summary>
        [XmlElement("visits")]
        public long Visits { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        [XmlElement("zip")]
        public string Zip { get; set; }
    }
}
