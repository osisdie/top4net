using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 商品属性列表的JSON响应解释器。
    /// </summary>
    public class ItemPropListJsonParser : ITopParser<List<ItemProp>>
    {
        #region ITopParser<ItemProp> Members

        public List<ItemProp> Parse(string body)
        {
            List<ItemProp> props = new List<ItemProp>();

            JObject jsonBody = JObject.Parse(body);
            JArray jsonProps = jsonBody["rsp"]["item_props"] as JArray;

            if (jsonProps != null)
            {
                for (int i = 0; i < jsonProps.Count; i++)
                {
                    JsonSerializer js = new JsonSerializer();
                    object prop = js.Deserialize(jsonProps[i].CreateReader(), typeof(ItemProp));
                    props.Add(prop as ItemProp);
                }
            }

            return props;
        }

        #endregion
    }
}
