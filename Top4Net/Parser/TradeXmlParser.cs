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

    /// <summary>
    /// 退款留言列表的XML响应解释器。
    /// </summary>
    public class RefundMessageListXmlParser : ITopParser<ResponseList<RefundMessage>>
    {
        #region ITopParser<ResponseList<RefundMessage>> Members

        public ResponseList<RefundMessage> Parse(string body)
        {
            return ResponseList<RefundMessage>.ParseXmlResponse("refundMessage", body);
        }

        #endregion
    }

    /// <summary>
    /// 退款留言的XML响应解释器。
    /// </summary>
    public class RefundMessageXmlParser : ITopParser<RefundMessage>
    {
        #region ITopParser<RefundMessage> Members

        public RefundMessage Parse(string body)
        {
            RefundMessageListXmlParser parser = new RefundMessageListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 确认收货费用列表的XML响应解释器。
    /// </summary>
    public class ConfirmFeeListXmlParser : ITopParser<ResponseList<ConfirmFee>>
    {
        #region ITopParser<ResponseList<ConfirmFee>> Members

        public ResponseList<ConfirmFee> Parse(string body)
        {
            return ResponseList<ConfirmFee>.ParseXmlResponse("confirmFee", body);
        }

        #endregion
    }

    /// <summary>
    /// 确认收货费的XML响应解释器。
    /// </summary>
    public class ConfirmFeeXmlParser : ITopParser<ConfirmFee>
    {
        #region ITopParser<ConfirmFee> Members

        public ConfirmFee Parse(string body)
        {
            ConfirmFeeListXmlParser parser = new ConfirmFeeListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
