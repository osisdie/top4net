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
    /// 商品的JSON响应解释器。
    /// </summary>
    public class ItemJsonParser : ITopParser<Item>
    {
        #region ITopParser<Item> Members

        public Item Parse(string body)
        {
            ItemListJsonParser parser = new ItemListJsonParser();
            return parser.Parse(body).GetFirst();
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
    /// 商品类目的JSON响应解释器。
    /// </summary>
    public class ItemCatJsonParser : ITopParser<ItemCategory>
    {
        #region ITopParser<ItemCategory> Members

        public ItemCategory Parse(string body)
        {
            ItemCatListJsonParser parser = new ItemCatListJsonParser();
            return parser.Parse(body).GetFirst();
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

    /// <summary>
    /// 商品搜索结果的JSON响应解释器。
    /// </summary>
    public class ItemSearchListJsonParser : ITopParser<ResponseList<ItemSearch>>
    {
        #region ITopParser<ResponseList<ItemSearch>> Members

        public ResponseList<ItemSearch> Parse(string body)
        {
            return ResponseList<ItemSearch>.ParseJsonResponse("itemsearchs", body);
        }

        #endregion
    }

    /// <summary>
    /// 商品图片列表的JSON响应解释器。
    /// </summary>
    public class ItemImgListJsonParser : ITopParser<ResponseList<ItemImg>>
    {
        #region ITopParser<ResponseList<ItemImg>> Members

        public ResponseList<ItemImg> Parse(string body)
        {
            return ResponseList<ItemImg>.ParseJsonResponse("itemImgs", body);
        }

        #endregion
    }

    /// <summary>
    /// 商品图片的JSON响应解释器。
    /// </summary>
    public class ItemImgJsonParser : ITopParser<ItemImg>
    {
        #region ITopParser<ItemImg> Members

        public ItemImg Parse(string body)
        {
            ItemImgListJsonParser parser = new ItemImgListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 属性图片列表的JSON响应解释器。
    /// </summary>
    public class PropImgListJsonParser : ITopParser<ResponseList<PropImg>>
    {
        #region ITopParser<ResponseList<PropImg>> Members

        public ResponseList<PropImg> Parse(string body)
        {
            return ResponseList<PropImg>.ParseJsonResponse("propImgs", body);
        }

        #endregion
    }

    /// <summary>
    /// 属性图片的JSON响应解释器。
    /// </summary>
    public class PropImgJsonParser : ITopParser<PropImg>
    {
        #region ITopParser<PropImg> Members

        public PropImg Parse(string body)
        {
            PropImgListJsonParser parser = new PropImgListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// SKU列表的JSON响应解释器。
    /// </summary>
    public class SkuListJsonParser : ITopParser<ResponseList<Sku>>
    {
        #region ITopParser<ResponseList<Sku>> Members

        public ResponseList<Sku> Parse(string body)
        {
            return ResponseList<Sku>.ParseJsonResponse("skus", body);
        }

        #endregion
    }

    /// <summary>
    /// SKU的JSON响应解释器。
    /// </summary>
    public class SkuJsonParser : ITopParser<Sku>
    {
        #region ITopParser<Sku> Members

        public Sku Parse(string body)
        {
            SkuListJsonParser parser = new SkuListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 邮费模板列表的JSON响应解释器。
    /// </summary>
    public class PostageListJsonParser : ITopParser<ResponseList<Postage>>
    {

        #region ITopParser<ResponseList<Postage>> Members

        public ResponseList<Postage> Parse(string body)
        {
            return ResponseList<Postage>.ParseJsonResponse("postages", body);
        }

        #endregion
    }

    /// <summary>
    /// 邮费模板的JSON响应解释器。
    /// </summary>
    public class PostageJsonParser : ITopParser<Postage>
    {
        #region ITopParser<Postage> Members

        public Postage Parse(string body)
        {
            PostageListJsonParser parser = new PostageListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
