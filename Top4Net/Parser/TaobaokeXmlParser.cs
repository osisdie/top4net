using System;
using System.Xml;

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
            return ResponseList<TaobaokeItem>.ParseXmlResponse("taobaokeItem", body);
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
            return parser.Parse(body).GetFirst();
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
            return ResponseList<TaobaokeShop>.ParseXmlResponse("taobaokeShop", body);
        }

        #endregion
    }

    /// <summary>
    /// 淘宝客店铺的XML响应解释器。
    /// </summary>
    public class TaobaokeShopXmlParser : ITopParser<TaobaokeShop>
    {
        #region ITopParser<TaobaokeShop> Members

        public TaobaokeShop Parse(string body)
        {
            TaobaokeShopListXmlParser parser = new TaobaokeShopListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 淘宝客报表列表的XML响应解释器。
    /// </summary>
    public class TaobaokeReportListXmlParser : ITopParser<ResponseList<TaobaokeReport>>
    {
        #region ITopParser<ResponseList<TaobaokeReport>> Members

        public ResponseList<TaobaokeReport> Parse(string body)
        {
            return ResponseList<TaobaokeReport>.ParseXmlResponse("taobaokeReport", body);
        }

        #endregion
    }

    /// <summary>
    /// 淘宝客报表的XML响应解释器。
    /// </summary>
    public class TaobaokeReportXmlParser : ITopParser<TaobaokeReport>
    {
        #region ITopParser<TaobaokeReport> Members

        public TaobaokeReport Parse(string body)
        {
            TaobaokeReportListXmlParser parser = new TaobaokeReportListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
