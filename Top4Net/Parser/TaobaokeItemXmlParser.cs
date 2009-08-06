using System;
using System.IO;
using System.Xml.Serialization;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 
    /// </summary>
    public class TaobaokeItemXmlParser : ITopParser<TaobaokeItem>
    {
        #region ITopParser<TaobaokeItem> Members

        public TaobaokeItem Parse(string body)
        {
            XmlSerializer serializer = new XmlSerializer( typeof( TaobaokeItemResponse ) );
            object obj = serializer.Deserialize( new StringReader( body ) );
            return ( obj as TaobaokeItemResponse ).TaobaokeItem;
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        [Serializable]
        [XmlRoot( "rsp" )]
        public class TaobaokeItemResponse
        {
            [XmlElement( "taobaokeitem" )]
            public TaobaokeItem TaobaokeItem { get; set; }
        }
    }
}