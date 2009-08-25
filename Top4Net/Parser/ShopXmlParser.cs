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
            return parser.Parse( body ).GetFirst();
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
            return ResponseList<Shop>.ParseXmlResponse( "shop", body );
        }

        #endregion
    }
}
