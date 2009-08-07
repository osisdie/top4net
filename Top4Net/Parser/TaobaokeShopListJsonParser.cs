using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 淘宝客店铺列表对象的JSON响应解释器。
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
}
