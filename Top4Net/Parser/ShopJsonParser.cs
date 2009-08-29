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
}
