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

    /// <summary>
    /// 商品属性的JSON响应解释器。
    /// </summary>
    public class ItemPropJsonParser : ITopParser<ItemProp>
    {
        #region ITopParser<ItemProp> Members

        public ItemProp Parse(string body)
        {
            ItemPropListJsonParser parser = new ItemPropListJsonParser();
            List<ItemProp> props = parser.Parse(body);

            if (props != null && props.Count > 0)
            {
                return props[0];
            }
            else
            {
                return null;
            }
        }

        #endregion
    }

    /// <summary>
    /// 商品类目列表的JSON响应解释器。
    /// </summary>
    public class ItemCatListJsonParser : ITopParser<List<ItemCategory>>
    {
        #region ITopParser<List<ItemCategory>> Members

        public List<ItemCategory> Parse(string body)
        {
            List<ItemCategory> props = new List<ItemCategory>();

            JObject jsonBody = JObject.Parse(body);
            JArray jsonProps = jsonBody["rsp"]["item_cats"] as JArray;

            if (jsonProps != null)
            {
                for (int i = 0; i < jsonProps.Count; i++)
                {
                    JsonSerializer js = new JsonSerializer();
                    object prop = js.Deserialize(jsonProps[i].CreateReader(), typeof(ItemCategory));
                    props.Add(prop as ItemCategory);
                }
            }

            return props;
        }

        #endregion
    }

    /// <summary>
    /// 属性值列表的JSON响应解释器。
    /// </summary>
    public class PropValueListJsonParser : ITopParser<List<PropValue>>
    {
        #region ITopParser<List<PropValue>> Members

        public List<PropValue> Parse(string body)
        {
            List<PropValue> values = new List<PropValue>();

            JObject jsonBody = JObject.Parse(body);
            JArray jsonProps = jsonBody["rsp"]["prop_values"] as JArray;

            if (jsonProps != null)
            {
                for (int i = 0; i < jsonProps.Count; i++)
                {
                    JsonSerializer js = new JsonSerializer();
                    object value = js.Deserialize(jsonProps[i].CreateReader(), typeof(PropValue));
                    values.Add(value as PropValue);
                }
            }

            return values;
        }

        #endregion
    }
}
