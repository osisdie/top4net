using System;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// PromotionDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PromotionDetail : BaseObject
    {
        [XmlElement("discount_fee")]
        public string DiscountFee { get; set; }

        [XmlElement("id")]
        public long Id { get; set; }

        [XmlElement("promotion_name")]
        public string PromotionName { get; set; }
    }
}
