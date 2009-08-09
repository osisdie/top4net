using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 淘宝客推广地址的XML响应解释器。
    /// </summary>
    public class TaobaokeListUrlXmlParser : ITopParser<string>
    {
        #region ITopParser<string> Members

        public string Parse(string body)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(body);
            XmlNode listUrl = xmlDoc.SelectSingleNode("/rsp/taobaokeItem/list_url_by_q");
            return listUrl == null ? null : listUrl.InnerText;
        }

        #endregion
    }

    /// <summary>
    /// 淘宝客商品列表的XML响应解释器。
    /// </summary>
    public class TaobaokeItemListXmlParser : ITopParser<ResponseList<TaobaokeItem>>
    {

        #region ITopParser<ResponseList<TaobaokeItem>> Members

        public ResponseList<TaobaokeItem> Parse(string body)
        {
            XmlAttributeOverrides attrs = ResponseList<TaobaokeItem>.GetOverrides("taobaokeItem");
            XmlSerializer serializer = new XmlSerializer(typeof(ResponseList<TaobaokeItem>), attrs);

            object obj = serializer.Deserialize(new StringReader(body));
            return obj as ResponseList<TaobaokeItem>;
        }

        #endregion
    }

    /// <summary>
    /// 淘宝客店铺列表的XML响应解释器。
    /// </summary>
    public class TaobaokeShopListXmlParser : ITopParser<ResponseList<TaobaokeShop>>
    {
        #region ITopParser<ResponseList<TaobaokeShop>> Members

        public ResponseList<TaobaokeShop> Parse(string body)
        {
            XmlAttributeOverrides attrs = ResponseList<TaobaokeShop>.GetOverrides("taobaokeShop");
            XmlSerializer serializer = new XmlSerializer(typeof(ResponseList<TaobaokeShop>), attrs);

            object obj = serializer.Deserialize(new StringReader(body));
            return obj as ResponseList<TaobaokeShop>;
        }

        #endregion
    }

    /// <summary>
    /// 淘宝客商品的XML响应解释器。
    /// </summary>
    public class TaobaokeItemXmlParser : ITopParser<TaobaokeItem>
    {
        #region ITopParser<TaobaokeItem> Members

        public TaobaokeItem Parse(string body)
        {
            TaobaokeItemListXmlParser parser = new TaobaokeItemListXmlParser();
            List<TaobaokeItem> items = parser.Parse(body).Content;

            if (items != null && items.Count > 0)
            {
                return items[0];
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}
