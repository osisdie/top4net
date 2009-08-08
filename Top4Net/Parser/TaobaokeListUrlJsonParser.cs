using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
}
