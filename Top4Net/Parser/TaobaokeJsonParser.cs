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
    public class TaobaokeShopListJsonParser : ITopParser<List<TaobaokeShop>>
    {

        #region ITopParser<List<TaobaokeShop>> Members

        public List<TaobaokeShop> Parse(string body)
        {
            List<TaobaokeShop> shops = new List<TaobaokeShop>();

            JObject jsonBody = JObject.Parse(body);
            JArray jsonShops = jsonBody["rsp"]["taobaokeShops"] as JArray;

            if (jsonShops != null)
            {
                for (int i = 0; i < jsonShops.Count; i++)
                {
                    JsonSerializer js = new JsonSerializer();
                    object shop = js.Deserialize(jsonShops[i].CreateReader(), typeof(TaobaokeShop));
                    shops.Add(shop as TaobaokeShop);
                }
            }

            return shops;
        }

        #endregion
    }

    /// <summary>
    /// 淘宝客商品列表的JSON响应解释器。
    /// </summary>
    public class TaobaokeItemListJsonParser : ITopParser<List<TaobaokeItem>>
    {
        #region ITopParser<List<TaobaokeItem>> Members

        public List<TaobaokeItem> Parse(string body)
        {
            List<TaobaokeItem> taobaokeItems = new List<TaobaokeItem>();

            JObject jsonBody = JObject.Parse(body);
            JArray jsonTaobaokeItems = jsonBody["rsp"]["taobaokeItems"] as JArray;

            if (jsonTaobaokeItems != null)
            {
                for (int i = 0; i < jsonTaobaokeItems.Count; i++)
                {
                    JsonSerializer js = new JsonSerializer();
                    object taobaokeItem = js.Deserialize(jsonTaobaokeItems[i].CreateReader(), typeof(TaobaokeItem));
                    taobaokeItems.Add(taobaokeItem as TaobaokeItem);
                }
            }

            return taobaokeItems;
        }

        #endregion
    }
}
