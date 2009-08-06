using System;
using System.IO;
using System.Xml.Serialization;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 淘宝客商品的XML响应解释器。
    /// </summary>
    public class TaobaokeItemXmlParser : ITopParser<TaobaokeItem>
    {
        #region ITopParser<TaobaokeItem> Members

        public TaobaokeItem Parse(string body)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TaobaokeItemResponse));
            object obj = serializer.Deserialize(new StringReader(body));
            return (obj as TaobaokeItemResponse).TaobaokeItem;
        }

        #endregion

        /// <summary>
        /// 淘宝客商品响应，用于XML反序列化。
        /// </summary>
        [Serializable]
        [XmlRoot("rsp")]
        public class TaobaokeItemResponse
        {
            [XmlElement("taobaokeitem")]
            public TaobaokeItem TaobaokeItem { get; set; }
        }
    }
}