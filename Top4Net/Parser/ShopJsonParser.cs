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
    public class ShopCategoryListJsonParser : ITopParser<ResponseList<ShopCategory>>
    {
        #region ITopParser<ResponseList<ShopCategory>> Members

        public ResponseList<ShopCategory> Parse(string body)
        {
            return ResponseList<ShopCategory>.ParseJsonResponse("shop_cats", body);
        }

        #endregion
    }

    /// <summary>
    /// 店铺类目的JSON响应解释器。
    /// </summary>
    public class ShopCategoryJsonParser : ITopParser<ShopCategory>
    {
        #region ITopParser<ShopCategory> Members

        public ShopCategory Parse(string body)
        {
            ShopCategoryListJsonParser parser = new ShopCategoryListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
