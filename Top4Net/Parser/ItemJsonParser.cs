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
    public class ItemPropListJsonParser : ITopParser<ResponseList<ItemProp>>
    {
        #region ITopParser<ResponseList<ItemProp>> Members

        public ResponseList<ItemProp> Parse(string body)
        {
            ResponseList<ItemProp> rspList = new ResponseList<ItemProp>();

            JObject jsonBody = JObject.Parse(body);
            JArray jsonProps = jsonBody["rsp"]["item_props"] as JArray;
            rspList.TotalResults = jsonBody["rsp"].Value<long>("totalResults");

            if (jsonProps != null)
            {
                List<ItemProp> props = new List<ItemProp>();
                for (int i = 0; i < jsonProps.Count; i++)
                {
                    JsonSerializer js = new JsonSerializer();
                    object prop = js.Deserialize(jsonProps[i].CreateReader(), typeof(ItemProp));
                    props.Add(prop as ItemProp);
                }
                rspList.Content = props;
            }

            return rspList;
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
            List<ItemProp> props = parser.Parse(body).Content;

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
    public class ItemCatListJsonParser : ITopParser<ResponseList<ItemCategory>>
    {
        #region ITopParser<ResponseList<ItemCategory>> Members

        public ResponseList<ItemCategory> Parse(string body)
        {
            ResponseList<ItemCategory> rspList = new ResponseList<ItemCategory>();

            JObject jsonBody = JObject.Parse(body);
            JArray jsonProps = jsonBody["rsp"]["item_cats"] as JArray;
            rspList.TotalResults = jsonBody["rsp"].Value<long>("totalResults");

            if (jsonProps != null)
            {
                List<ItemCategory> props = new List<ItemCategory>();
                for (int i = 0; i < jsonProps.Count; i++)
                {
                    JsonSerializer js = new JsonSerializer();
                    object prop = js.Deserialize(jsonProps[i].CreateReader(), typeof(ItemCategory));
                    props.Add(prop as ItemCategory);
                }
                rspList.Content = props;
            }

            return rspList;
        }

        #endregion
    }

    /// <summary>
    /// 属性值列表的JSON响应解释器。
    /// </summary>
    public class PropValueListJsonParser : ITopParser<ResponseList<PropValue>>
    {
        #region ITopParser<ResponseList<PropValue>> Members

        public ResponseList<PropValue> Parse(string body)
        {
            ResponseList<PropValue> rspList = new ResponseList<PropValue>();


            JObject jsonBody = JObject.Parse(body);
            JArray jsonProps = jsonBody["rsp"]["prop_values"] as JArray;
            rspList.TotalResults = jsonBody["rsp"].Value<long>("totalResults");

            if (jsonProps != null)
            {
                List<PropValue> values = new List<PropValue>();
                for (int i = 0; i < jsonProps.Count; i++)
                {
                    JsonSerializer js = new JsonSerializer();
                    object value = js.Deserialize(jsonProps[i].CreateReader(), typeof(PropValue));
                    values.Add(value as PropValue);
                }
                rspList.Content = values;
            }

            return rspList;
        }

        #endregion
    }
}
