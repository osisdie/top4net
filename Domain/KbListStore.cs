using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// KbListStore Data Structure.
    /// </summary>
    [Serializable]
    public class KbListStore : TopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 点评的数量
        /// </summary>
        [XmlElement("appraisement_count")]
        public string AppraisementCount { get; set; }

        /// <summary>
        /// 店铺大类
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

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
        /// 口碑指数
        /// </summary>
        [XmlElement("colligate_exponent")]
        public string ColligateExponent { get; set; }

        /// <summary>
        /// 精选的某一条评论内容
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 折扣 几折
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 打折提示信息
        /// </summary>
        [XmlElement("discount_notes")]
        public string DiscountNotes { get; set; }

        /// <summary>
        /// 平均价格
        /// </summary>
        [XmlElement("per_price")]
        public string PerPrice { get; set; }

        /// <summary>
        /// 店铺图片的URL
        /// </summary>
        [XmlElement("pic_store")]
        public string PicStore { get; set; }

        /// <summary>
        /// 电话图片的URL
        /// </summary>
        [XmlElement("pic_tel_no")]
        public string PicTelNo { get; set; }

        /// <summary>
        /// UUID随机生成，另外会根据业务加一些前缀
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 回头率
        /// </summary>
        [XmlElement("review_rate")]
        public long ReviewRate { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 店铺图片的数量
        /// </summary>
        [XmlElement("store_pic_count")]
        public long StorePicCount { get; set; }

        /// <summary>
        /// 店铺小类
        /// </summary>
        [XmlElement("sub_categories")]
        public string SubCategories { get; set; }
    }
}
