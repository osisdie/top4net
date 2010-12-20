using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// KbDetailCoupon Data Structure.
    /// </summary>
    [Serializable]
    public class KbDetailCoupon : TopObject
    {
        /// <summary>
        /// 优惠商家地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 老板是否活跃
        /// </summary>
        [XmlElement("boss_active")]
        public bool BossActive { get; set; }

        /// <summary>
        /// 城市ID
        /// </summary>
        [XmlElement("city_id")]
        public long CityId { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 点评数
        /// </summary>
        [XmlElement("comment_count")]
        public string CommentCount { get; set; }

        /// <summary>
        /// 优惠内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 是否有活动
        /// </summary>
        [XmlElement("has_activity")]
        public bool HasActivity { get; set; }

        /// <summary>
        /// 是否有优惠
        /// </summary>
        [XmlElement("has_discount")]
        public bool HasDiscount { get; set; }

        /// <summary>
        /// 是否有更多图片
        /// </summary>
        [XmlElement("has_img")]
        public bool HasImg { get; set; }

        /// <summary>
        /// 是否有网友印象
        /// </summary>
        [XmlElement("has_impress")]
        public bool HasImpress { get; set; }

        /// <summary>
        /// 是否有地图
        /// </summary>
        [XmlElement("has_map")]
        public bool HasMap { get; set; }

        /// <summary>
        /// 人气值（也可理解为点击量）
        /// </summary>
        [XmlElement("hits")]
        public string Hits { get; set; }

        /// <summary>
        /// 按照一定规则产生的数字串
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 优惠detail图片地址
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 人均价格，不带单位符号
        /// </summary>
        [XmlElement("per_capital")]
        public string PerCapital { get; set; }

        /// <summary>
        /// 商圈地址
        /// </summary>
        [XmlElement("peri_place")]
        public string PeriPlace { get; set; }

        /// <summary>
        /// 商家联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 电话号码的URL图片
        /// </summary>
        [XmlElement("phone_url")]
        public string PhoneUrl { get; set; }

        /// <summary>
        /// 地理坐标的维度
        /// </summary>
        [XmlElement("posx")]
        public string Posx { get; set; }

        /// <summary>
        /// 地理坐标的经度
        /// </summary>
        [XmlElement("posy")]
        public string Posy { get; set; }

        /// <summary>
        /// 打印量
        /// </summary>
        [XmlElement("print_count")]
        public string PrintCount { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [XmlElement("publish_time")]
        public string PublishTime { get; set; }

        /// <summary>
        /// 推荐菜,多个推荐菜用英文逗号分隔
        /// </summary>
        [XmlElement("recommend_food")]
        public string RecommendFood { get; set; }

        /// <summary>
        /// 短信下载量
        /// </summary>
        [XmlElement("sms_count")]
        public string SmsCount { get; set; }

        /// <summary>
        /// 店铺的ID号
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 优惠券所在的店铺名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 子类目名称
        /// </summary>
        [XmlElement("sub_cate")]
        public string SubCate { get; set; }

        /// <summary>
        /// 优惠券的标题，格式如：[店铺名]优惠券名
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 回头率，不带单位符号
        /// </summary>
        [XmlElement("turn_rate")]
        public string TurnRate { get; set; }

        /// <summary>
        /// 优惠类型+"|"+折扣数或抵价金额,如果没有折扣数或金额，则只显示打折类型，例如:折扣券|7,抵价券|10,优惠券
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 有效时间
        /// </summary>
        [XmlElement("validate_time")]
        public string ValidateTime { get; set; }
    }
}
