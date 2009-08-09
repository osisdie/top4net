using System;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 商品列表的JSON响应解释器。
    /// </summary>
    public class ItemListJsonParser : ITopParser<ResponseList<Item>>
    {
        #region ITopParser<ResponseList<Item>> Members

        public ResponseList<Item> Parse(string body)
        {
            return ResponseList<Item>.ParseJsonResponse("items", body);
        }

        #endregion
    }

    /// <summary>
    /// 商品属性列表的JSON响应解释器。
    /// </summary>
    public class ItemPropListJsonParser : ITopParser<ResponseList<ItemProp>>
    {
        #region ITopParser<ResponseList<ItemProp>> Members

        public ResponseList<ItemProp> Parse(string body)
        {
            return ResponseList<ItemProp>.ParseJsonResponse("item_props", body);
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
            return parser.Parse(body).GetFirst();
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
            return ResponseList<ItemCategory>.ParseJsonResponse("item_cats", body);
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
            return ResponseList<PropValue>.ParseJsonResponse("prop_values", body);
        }

        #endregion
    }
}
