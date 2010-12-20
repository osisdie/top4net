using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// KbListCoupon Data Structure.
    /// </summary>
    [Serializable]
    public class KbListCoupon : TopObject
    {
        /// <summary>
        /// 商家地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 优惠内容，不截字
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 下载量
        /// </summary>
        [XmlElement("download_count")]
        public string DownloadCount { get; set; }

        /// <summary>
        /// 截止日期
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 该条优惠卷所拥有的标志，比如：独家，标志与标志间用英文逗号分隔
        /// </summary>
        [XmlElement("flag")]
        public string Flag { get; set; }

        /// <summary>
        /// 按照一定规则产生的数字串
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 优惠list图片地址
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 商圈地址
        /// </summary>
        [XmlElement("peri_place")]
        public string PeriPlace { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 子类目id
        /// </summary>
        [XmlElement("sub_cate")]
        public long SubCate { get; set; }

        /// <summary>
        /// 分类目名称
        /// </summary>
        [XmlElement("sub_cate_name")]
        public string SubCateName { get; set; }

        /// <summary>
        /// 是否支持短信下载
        /// </summary>
        [XmlElement("support_sms")]
        public bool SupportSms { get; set; }

        /// <summary>
        /// 优惠title，不截字
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 优惠类型+"|"+折扣数或抵价金额,如果没有折扣数或金额，则只显示打折类型，例如:折扣券|7,抵价券|10,优惠券
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
