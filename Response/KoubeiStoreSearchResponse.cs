using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// KoubeiStoreSearchResponse.
    /// </summary>
    public class KoubeiStoreSearchResponse : TopResponse
    {
        /// <summary>
        /// 返回满足查询条件的店铺集，无则返回null
        /// </summary>
        [XmlArray("kb_list_stores")]
        [XmlArrayItem("kb_list_store")]
        public List<KbListStore> KbListStores { get; set; }

        /// <summary>
        /// 总的数量
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
