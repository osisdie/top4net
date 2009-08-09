using System;
using System.Collections.Generic;

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
    /// 淘宝客店铺列表的JSON响应解释器。
    /// </summary>
    public class TaobaokeShopListJsonParser : ITopParser<ResponseList<TaobaokeShop>>
    {

        #region ITopParser<ResponseList<TaobaokeShop>> Members

        public ResponseList<TaobaokeShop> Parse(string body)
        {
            ResponseList<TaobaokeShop> rspList = new ResponseList<TaobaokeShop>();

            JObject jsonBody = JObject.Parse(body);
            JArray jsonShops = jsonBody["rsp"]["taobaokeShops"] as JArray;
            rspList.TotalResults = jsonBody["rsp"].Value<long>("totalResults");

            if (jsonShops != null)
            {
                List<TaobaokeShop> shops = new List<TaobaokeShop>();
                for (int i = 0; i < jsonShops.Count; i++)
                {
                    JsonSerializer js = new JsonSerializer();
                    object shop = js.Deserialize(jsonShops[i].CreateReader(), typeof(TaobaokeShop));
                    shops.Add(shop as TaobaokeShop);
                }
                rspList.Content = shops;
            }

            return rspList;
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
            ResponseList<TaobaokeItem> rspList = new ResponseList<TaobaokeItem>();


            JObject jsonBody = JObject.Parse(body);
            JArray jsonItems = jsonBody["rsp"]["taobaokeItems"] as JArray;
            rspList.TotalResults = jsonBody["rsp"].Value<long>("totalResults");

            if (jsonItems != null)
            {
                List<TaobaokeItem> items = new List<TaobaokeItem>();
                for (int i = 0; i < jsonItems.Count; i++)
                {
                    JsonSerializer js = new JsonSerializer();
                    object item = js.Deserialize(jsonItems[i].CreateReader(), typeof(TaobaokeItem));
                    items.Add(item as TaobaokeItem);
                }
                rspList.Content = items;
            }

            return rspList;
        }

        #endregion
    }
}
