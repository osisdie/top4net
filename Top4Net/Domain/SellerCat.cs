using System;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// SellerCat Data Structure.
    /// </summary>
    [Serializable]
    public class SellerCat : BaseObject
    {
        [XmlElement("cid")]
        public int Cid { get; set; }

        [XmlElement("created")]
        public string Created { get; set; }

        [XmlElement("modified")]
        public string Modified { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("parent_cid")]
        public int ParentCid { get; set; }

        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        [XmlElement("sort_order")]
        public int SortOrder { get; set; }
    }
}
