using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    public class TaobaokeItemListXmlParser : ITopParser<List<TaobaokeItem>>
    {
        public List<TaobaokeItem> Parse(string body)
        {
            XmlSerializer serializer = new XmlSerializer( typeof( TaobaokeItemListResponse ) );

            object obj = serializer.Deserialize( new StringReader( body ) );
            TaobaokeItemListResponse tir = obj as TaobaokeItemListResponse;
            return tir == null ? null : tir.TaobaokeItems;
        }

        /// <summary>
        /// 产品列表响应，用于XML反序列化。
        /// </summary>
        [Serializable]
        [XmlRoot( "rsp" )]
        public class TaobaokeItemListResponse
        {
            [XmlElement( "taobaokeItem" )]
            public List<TaobaokeItem> TaobaokeItems { get; set; }
        }
    }
}
