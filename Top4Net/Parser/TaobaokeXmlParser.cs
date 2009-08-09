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
    public class TaobaokeItemListXmlParser : ITopParser<List<TaobaokeItem>>
    {
        public List<TaobaokeItem> Parse(string body)
        {
            XmlAttributeOverrides attrs = ResponseList<TaobaokeItem>.GetOverrides("taobaokeItem");
            XmlSerializer serializer = new XmlSerializer(typeof(ResponseList<TaobaokeItem>), attrs);

            object obj = serializer.Deserialize(new StringReader(body));
            ResponseList<TaobaokeItem> rsp = obj as ResponseList<TaobaokeItem>;
            return rsp == null ? null : rsp.Content;
        }
    }

    /// <summary>
    /// 淘宝客店铺列表的XML响应解释器。
    /// </summary>
    public class TaobaokeShopListXmlParser : ITopParser<List<TaobaokeShop>>
    {
        #region ITopParser<List<TaobaokeShop>> Members

        public List<TaobaokeShop> Parse(string body)
        {
            XmlAttributeOverrides attrs = ResponseList<TaobaokeShop>.GetOverrides("taobaokeShop");
            XmlSerializer serializer = new XmlSerializer(typeof(ResponseList<TaobaokeShop>), attrs);

            object obj = serializer.Deserialize(new StringReader(body));
            ResponseList<TaobaokeShop> rsp = obj as ResponseList<TaobaokeShop>;
            return rsp == null ? null : rsp.Content;
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
            List<TaobaokeItem> items = parser.Parse(body);

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
