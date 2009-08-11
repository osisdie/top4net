using System;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 交易列表的JSON响应解释器。
    /// </summary>
    public class TradeListJsonParser : ITopParser<ResponseList<Trade>>
    {
        #region ITopParser<ResponseList<Trade>> Members

        public ResponseList<Trade> Parse(string body)
        {
            return ResponseList<Trade>.ParseJsonResponse("trades", body);
        }

        #endregion
    }

    /// <summary>
    /// 交易的JSON响应解释器。
    /// </summary>
    public class TradeJsonParser : ITopParser<Trade>
    {
        #region ITopParser<Trade> Members

        public Trade Parse(string body)
        {
            TradeListJsonParser parser = new TradeListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 订单列表的JSON响应解释器。
    /// </summary>
    public class OrderListJsonParser : ITopParser<ResponseList<Order>>
    {
        #region ITopParser<ResponseList<Order>> Members

        public ResponseList<Order> Parse(string body)
        {
            return ResponseList<Order>.ParseJsonResponse("orders", body);
        }

        #endregion
    }

    /// <summary>
    /// 订单的JSON响应解释器。
    /// </summary>
    public class OrderJsonParser : ITopParser<Order>
    {
        #region ITopParser<Order> Members

        public Order Parse(string body)
        {
            OrderListJsonParser parser = new OrderListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
