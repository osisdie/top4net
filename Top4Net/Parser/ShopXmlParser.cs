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
    public class ShopCategoryListXmlParser : ITopParser<ResponseList<ShopCategory>>
    {
        #region ITopParser<ResponseList<Product>> Members

        public ResponseList<ShopCategory> Parse(string body)
        {
            return ResponseList<ShopCategory>.ParseXmlResponse("shop_cat", body);
        }

        #endregion
    }

    /// <summary>
    /// 店铺类目的XML响应解释器。
    /// </summary>
    public class ShopCategoryXmlParser : ITopParser<ShopCategory>
    {
        #region ITopParser<ShopCategory> Members

        public ShopCategory Parse(string body)
        {
            ShopCategoryListXmlParser parser = new ShopCategoryListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 卖家自定义商品类目列表的XML响应解释器。
    /// </summary>
    public class SellerItemCategoryListXmlParser : ITopParser<ResponseList<SellerItemCategory>>
    {
        #region ITopParser<ResponseList<SellerItemCategory>> Members

        public ResponseList<SellerItemCategory> Parse(string body)
        {
            return ResponseList<SellerItemCategory>.ParseXmlResponse("seller_cat", body);
        }

        #endregion
    }

    /// <summary>
    /// 卖家自定义商品类目的XML响应解释器。
    /// </summary>
    public class SellerItemCategoryXmlParser : ITopParser<SellerItemCategory>
    {
        #region ITopParser<SellerItemCategory> Members

        public SellerItemCategory Parse(string body)
        {
            SellerItemCategoryListXmlParser parser = new SellerItemCategoryListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
