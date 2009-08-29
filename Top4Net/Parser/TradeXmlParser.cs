using System;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 交易列表的XML响应解释器。
    /// </summary>
    public class TradeListXmlParser : ITopParser<ResponseList<Trade>>
    {
        #region ITopParser<ResponseList<Trade>> Members

        public ResponseList<Trade> Parse(string body)
        {
            return ResponseList<Trade>.ParseXmlResponse("trade", body);
        }

        #endregion
    }

    /// <summary>
    /// 交易的XML响应解释器。
    /// </summary>
    public class TradeXmlParser : ITopParser<Trade>
    {
        #region ITopParser<Trade> Members

        public Trade Parse(string body)
        {
            TradeListXmlParser parser = new TradeListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 订单列表的XML响应解释器。
    /// </summary>
    public class OrderListXmlParser : ITopParser<ResponseList<Order>>
    {
        #region ITopParser<ResponseList<Order>> Members

        public ResponseList<Order> Parse(string body)
        {
            return ResponseList<Order>.ParseXmlResponse("order", body);
        }

        #endregion
    }

    /// <summary>
    /// 订单的XML响应解释器。
    /// </summary>
    public class OrderXmlParser : ITopParser<Order>
    {
        #region ITopParser<Order> Members

        public Order Parse(string body)
        {
            OrderListXmlParser parser = new OrderListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 退款列表的XML响应解释器。
    /// </summary>
    public class RefundListXmlParser : ITopParser<ResponseList<Refund>>
    {
        #region ITopParser<ResponseList<Refund>> Members

        public ResponseList<Refund> Parse(string body)
        {
            return ResponseList<Refund>.ParseXmlResponse("refund", body);
        }

        #endregion
    }

    /// <summary>
    /// 退款的XML响应解释器。
    /// </summary>
    public class RefundXmlParser : ITopParser<Refund>
    {
        #region ITopParser<Refund> Members

        public Refund Parse(string body)
        {
            RefundListXmlParser parser = new RefundListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
