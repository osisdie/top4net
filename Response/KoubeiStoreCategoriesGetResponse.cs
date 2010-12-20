using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// KoubeiStoreCategoriesGetResponse.
    /// </summary>
    public class KoubeiStoreCategoriesGetResponse : TopResponse
    {
        /// <summary>
        /// 返回指定类目id的子类目集，无返回null
        /// </summary>
        [XmlArray("kb_store_cats")]
        [XmlArrayItem("kb_store_cat")]
        public List<KbStoreCat> KbStoreCats { get; set; }
    }
}
