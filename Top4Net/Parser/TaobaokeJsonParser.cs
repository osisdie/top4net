using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 淘宝客推广地址的JSON响应解释器。
    /// </summary>
    public class TaobaokeListUrlJsonParser : ITopParser<string>
    {
        #region ITopParser<string> Members

        public string Parse(string body)
        {
            string listUrl = null;

            JObject jsonBody = JObject.Parse(body);
            JArray jsonTaobaokeItems = jsonBody["rsp"]["taobaokeItems"] as JArray;

            if (jsonTaobaokeItems != null && jsonTaobaokeItems.Count > 0)
            {
                listUrl = jsonTaobaokeItems[0].Value<string>("list_url_by_q");
            }

            return listUrl;
        }

        #endregion
    }

    /// <summary>
    /// 淘宝客商品列表的JSON响应解释器。
    /// </summary>
    public class TaobaokeItemListJsonParser : ITopParser<ResponseList<TaobaokeItem>>
    {
        #region ITopParser<ResponseList<TaobaokeItem>> Members

        public ResponseList<TaobaokeItem> Parse(string body)
        {
            return ResponseList<TaobaokeItem>.ParseJsonResponse("taobaokeItems", body);
        }

        #endregion
    }

    /// <summary>
    /// 淘宝客商品的JSON响应解释器。
    /// </summary>
    public class TaobaokeItemJsonParser : ITopParser<TaobaokeItem>
    {
        #region ITopParser<TaobaokeItem> Members

        public TaobaokeItem Parse(string body)
        {
            TaobaokeItemListJsonParser parser = new TaobaokeItemListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 淘宝客店铺列表的JSON响应解释器。
    /// </summary>
    public class TaobaokeShopListJsonParser : ITopParser<ResponseList<TaobaokeShop>>
    {

        #region ITopParser<ResponseList<TaobaokeShop>> Members

        public ResponseList<TaobaokeShop> Parse(string body)
        {
            return ResponseList<TaobaokeShop>.ParseJsonResponse("taobaokeShops", body);
        }

        #endregion
    }

    /// <summary>
    /// 淘宝客店铺的JSON响应解释器。
    /// </summary>
    public class TaobaokeShopJsonParser : ITopParser<TaobaokeShop>
    {
        #region ITopParser<TaobaokeShop> Members

        public TaobaokeShop Parse(string body)
        {
            TaobaokeShopListJsonParser parser = new TaobaokeShopListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 淘宝客报表列表的JSON响应解释器。
    /// </summary>
    public class TaobaokeReportListJsonParser : ITopParser<ResponseList<TaobaokeReport>>
    {
        #region ITopParser<ResponseList<TaobaokeReport>> Members

        public ResponseList<TaobaokeReport> Parse(string body)
        {
            return ResponseList<TaobaokeReport>.ParseJsonResponse("taobaokeReports", body);
        }

        #endregion
    }

    /// <summary>
    /// 淘宝客报表的JSON响应解释器。
    /// </summary>
    public class TaobaokeReportJsonParser : ITopParser<TaobaokeReport>
    {
        #region ITopParser<TaobaokeReport> Members

        public TaobaokeReport Parse(string body)
        {
            TaobaokeReportListJsonParser parser = new TaobaokeReportListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
