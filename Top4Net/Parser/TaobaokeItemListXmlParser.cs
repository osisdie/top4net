using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 淘宝客商品列表的XML响应解释器。
    /// </summary>
    public class TaobaokeItemListXmlParser : ITopParser<List<TaobaokeItem>>
    {
        public List<TaobaokeItem> Parse(string body)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TaobaokeItemListResponse));

            object obj = serializer.Deserialize(new StringReader(body));
            TaobaokeItemListResponse tir = obj as TaobaokeItemListResponse;
            return tir == null ? null : tir.TaobaokeItems;
        }

        /// <summary>
        /// 淘宝客商品列表响应，用于XML反序列化。
        /// </summary>
        [Serializable]
        [XmlRoot("rsp")]
        public class TaobaokeItemListResponse
        {
            [XmlElement("taobaokeItem")]
            public List<TaobaokeItem> TaobaokeItems { get; set; }
        }
    }
}
