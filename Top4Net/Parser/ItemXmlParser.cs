using System;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 商品列表的XML响应解释器。
    /// </summary>
    public class ItemListXmlParser : ITopParser<ResponseList<Item>>
    {
        #region ITopParser<ResponseList<Item>> Members

        public ResponseList<Item> Parse(string body)
        {
            return ResponseList<Item>.ParseXmlResponse("item", body);
        }

        #endregion
    }

    /// <summary>
    /// 商品的XML响应解释器。
    /// </summary>
    public class ItemXmlParser : ITopParser<Item>
    {
        #region ITopParser<Item> Members

        public Item Parse(string body)
        {
            ItemListXmlParser parser = new ItemListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 商品属性列表的XML响应解释器。
    /// </summary>
    public class ItemPropListXmlParser : ITopParser<ResponseList<ItemProp>>
    {
        #region ITopParser<ResponseList<ItemProp>> Members

        public ResponseList<ItemProp> Parse(string body)
        {
            return ResponseList<ItemProp>.ParseXmlResponse("item_prop", body);
        }

        #endregion
    }

    /// <summary>
    /// 商品属性的XML响应解释器。
    /// </summary>
    public class ItemPropXmlParser : ITopParser<ItemProp>
    {
        #region ITopParser<ItemProp> Members

        public ItemProp Parse(string body)
        {
            ItemPropListXmlParser parser = new ItemPropListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 商品类目列表的XML响应解释器。
    /// </summary>
    public class ItemCatListXmlParser : ITopParser<ResponseList<ItemCategory>>
    {
        #region ITopParser<ResponseList<ItemCategory>> Members

        public ResponseList<ItemCategory> Parse(string body)
        {
            return ResponseList<ItemCategory>.ParseXmlResponse("item_cat", body);
        }

        #endregion
    }

    /// <summary>
    /// 商品类目的XML响应解释器。
    /// </summary>
    public class ItemCatXmlParser : ITopParser<ItemCategory>
    {
        #region ITopParser<ItemCategory> Members

        public ItemCategory Parse(string body)
        {
            ItemCatListXmlParser parser = new ItemCatListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 属性值列表的XML响应解释器。
    /// </summary>
    public class PropValueListXmlParser : ITopParser<ResponseList<PropValue>>
    {
        #region ITopParser<ResponseList<PropValue>> Members

        public ResponseList<PropValue> Parse(string body)
        {
            return ResponseList<PropValue>.ParseXmlResponse("prop_value", body);
        }

        #endregion
    }

    /// <summary>
    /// 商品搜索结果的XML响应解释器。
    /// </summary>
    public class ItemSearchListXmlParser : ITopParser<ResponseList<ItemSearch>>
    {
        #region ITopParser<ResponseList<ItemSearch>> Members

        public ResponseList<ItemSearch> Parse(string body)
        {
            return ResponseList<ItemSearch>.ParseXmlResponse("itemsearch", body);
        }

        #endregion
    }

    /// <summary>
    /// 商品图片列表的XML响应解释器。
    /// </summary>
    public class ItemImgListXmlParser : ITopParser<ResponseList<ItemImg>>
    {
        #region ITopParser<ResponseList<ItemImg>> Members

        public ResponseList<ItemImg> Parse(string body)
        {
            return ResponseList<ItemImg>.ParseXmlResponse("itemImg", body);
        }

        #endregion
    }

    /// <summary>
    /// 商品图片的XML响应解释器。
    /// </summary>
    public class ItemImgXmlParser : ITopParser<ItemImg>
    {
        #region ITopParser<ItemImg> Members

        public ItemImg Parse(string body)
        {
            ItemImgListXmlParser parser = new ItemImgListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 属性图片列表的XML响应解释器。
    /// </summary>
    public class PropImgListXmlParser : ITopParser<ResponseList<PropImg>>
    {
        #region ITopParser<ResponseList<PropImg>> Members

        public ResponseList<PropImg> Parse(string body)
        {
            return ResponseList<PropImg>.ParseXmlResponse("propImg", body);
        }

        #endregion
    }

    /// <summary>
    /// 属性图片的XML响应解释器。
    /// </summary>
    public class PropImgXmlParser : ITopParser<PropImg>
    {
        #region ITopParser<PropImg> Members

        public PropImg Parse(string body)
        {
            PropImgListXmlParser parser = new PropImgListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
