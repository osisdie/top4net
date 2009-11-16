using System;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 店铺的XML响应解释器
    /// </summary>
    public class ShopXmlParser : ITopParser<Shop>
    {
        #region ITopParser<Shop> Members

        public Shop Parse(string body)
        {
            ShopListXmlParser parser = new ShopListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 店铺列表的XML响应解释器。
    /// </summary>
    public class ShopListXmlParser : ITopParser<ResponseList<Shop>>
    {
        #region ITopParser<ResponseList<Product>> Members

        public ResponseList<Shop> Parse(string body)
        {
            return ResponseList<Shop>.ParseXmlResponse("shop", body);
        }

        #endregion
    }

    /// <summary>
    /// 店铺类目列表的XML响应解释器。
    /// </summary>
    public class ShopCatListXmlParser : ITopParser<ResponseList<ShopCat>>
    {
        #region ITopParser<ResponseList<Product>> Members

        public ResponseList<ShopCat> Parse(string body)
        {
            return ResponseList<ShopCat>.ParseXmlResponse("shop_cat", body);
        }

        #endregion
    }

    /// <summary>
    /// 店铺类目的XML响应解释器。
    /// </summary>
    public class ShopCatXmlParser : ITopParser<ShopCat>
    {
        #region ITopParser<ShopCategory> Members

        public ShopCat Parse(string body)
        {
            ShopCatListXmlParser parser = new ShopCatListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 卖家自定义商品类目列表的XML响应解释器。
    /// </summary>
    public class SellerCatListXmlParser : ITopParser<ResponseList<SellerCat>>
    {
        #region ITopParser<ResponseList<SellerCategory>> Members

        public ResponseList<SellerCat> Parse(string body)
        {
            return ResponseList<SellerCat>.ParseXmlResponse("seller_cat", body);
        }

        #endregion
    }

    /// <summary>
    /// 卖家自定义商品类目的XML响应解释器。
    /// </summary>
    public class SellerCatXmlParser : ITopParser<SellerCat>
    {
        #region ITopParser<SellerCategory> Members

        public SellerCat Parse(string body)
        {
            SellerCatListXmlParser parser = new SellerCatListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
