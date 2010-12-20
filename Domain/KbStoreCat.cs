using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// KbStoreCat Data Structure.
    /// </summary>
    [Serializable]
    public class KbStoreCat : TopObject
    {
        /// <summary>
        /// 分类等级
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 类目的父级id
        /// </summary>
        [XmlElement("parent_id")]
        public long ParentId { get; set; }

        /// <summary>
        /// 数字类型的ID
        /// </summary>
        [XmlElement("store_category_id")]
        public long StoreCategoryId { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [XmlElement("store_category_name")]
        public string StoreCategoryName { get; set; }
    }
}
