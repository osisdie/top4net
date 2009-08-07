using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 淘宝客店铺列表对象的XML响应解释器。
    /// </summary>
    public class TaobaokeShopListXmlParser : ITopParser<List<TaobaokeShop>>
    {
        #region ITopParser<List<TaobaokeShop>> Members

        public List<TaobaokeShop> Parse(string body)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TaobaokeShopListResponse));
            object obj = serializer.Deserialize(new StringReader(body));
            TaobaokeShopListResponse rsp = obj as TaobaokeShopListResponse;
            return rsp == null ? null : rsp.Shops;
        }

        #endregion
    }

    /// <summary>
    /// 淘宝客店铺列表响应，用于XML反序列化。
    /// </summary>
    [Serializable]
    [XmlRoot("rsp")]
    public class TaobaokeShopListResponse
    {
        [XmlElement("taobaokeShop")]
        public List<TaobaokeShop> Shops { get; set; }
    }
}
