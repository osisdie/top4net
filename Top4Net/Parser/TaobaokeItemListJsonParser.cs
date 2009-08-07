using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 淘宝客商品列表对象的JSON响应解释器。
    /// </summary>
    public class TaobaokeItemListJsonParser : ITopParser<List<TaobaokeItem>>
    {
        #region ITopParser<List<TaobaokeItem>> Members

        public List<TaobaokeItem> Parse(string body)
        {
            List<TaobaokeItem> taobaokeItems = new List<TaobaokeItem>();

            JObject jsonBody = JObject.Parse(body);
            JArray jsonTaobaokeItems = jsonBody["rsp"]["taobaokeItem"] as JArray;

            if ( jsonTaobaokeItems != null )
            {
                for ( int i = 0; i < jsonTaobaokeItems.Count; i++ )
                {
                    JsonSerializer js = new JsonSerializer();
                    object taobaokeItem = js.Deserialize( jsonTaobaokeItems[i].CreateReader(), typeof( TaobaokeItem ) );
                    taobaokeItems.Add( taobaokeItem as TaobaokeItem );
                }
            }

            return taobaokeItems;
        }

        #endregion
    }
}