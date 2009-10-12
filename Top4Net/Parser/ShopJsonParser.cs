using System;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 店铺的JSON响应解释器。
    /// </summary>
    public class ShopJsonParser : ITopParser<Shop>
    {
        #region ITopParser<Shop> Members

        public Shop Parse(string body)
        {
            ShopListJsonParser parser = new ShopListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 店铺列表的JSON响应解释器。
    /// </summary>
    public class ShopListJsonParser : ITopParser<ResponseList<Shop>>
    {
        #region ITopParser<ResponseList<Shop>> Members

        public ResponseList<Shop> Parse(string body)
        {
            return ResponseList<Shop>.ParseJsonResponse("shops", body);
        }

        #endregion
    }

    /// <summary>
    /// 店铺类目列表的JSON响应解释器。
    /// </summary>
    public class ShopCatListJsonParser : ITopParser<ResponseList<ShopCat>>
    {
        #region ITopParser<ResponseList<ShopCategory>> Members

        public ResponseList<ShopCat> Parse(string body)
        {
            return ResponseList<ShopCat>.ParseJsonResponse("shop_cats", body);
        }

        #endregion
    }

    /// <summary>
    /// 店铺类目的JSON响应解释器。
    /// </summary>
    public class ShopCatJsonParser : ITopParser<ShopCat>
    {
        #region ITopParser<ShopCategory> Members

        public ShopCat Parse(string body)
        {
            ShopCatListJsonParser parser = new ShopCatListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    ///  卖家自定义商品类目列表的JSON响应解释器。
    /// </summary>
    public class SellerItemCatListJsonParser : ITopParser<ResponseList<SellerItemCat>>
    {
        #region ITopParser<ResponseList<SellerItemCategory>> Members

        public ResponseList<SellerItemCat> Parse(string body)
        {
            return ResponseList<SellerItemCat>.ParseJsonResponse("seller_cats", body);
        }

        #endregion
    }

    /// <summary>
    /// 卖家自定义商品类目的JSON响应解释器。
    /// </summary>
    public class SellerItemCatJsonParser : ITopParser<SellerItemCat>
    {
        #region ITopParser<SellerItemCategory> Members

        public SellerItemCat Parse(string body)
        {
            SellerItemCatListJsonParser parser = new SellerItemCatListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
