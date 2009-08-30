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

    /// <summary>
    /// 退款列表的JSON响应解释器。
    /// </summary>
    public class RefundListJsonParser : ITopParser<ResponseList<Refund>>
    {
        #region ITopParser<ResponseList<Refund>> Members

        public ResponseList<Refund> Parse(string body)
        {
            return ResponseList<Refund>.ParseJsonResponse("refunds", body);
        }

        #endregion
    }

    /// <summary>
    /// 退款的JSON响应解释器。
    /// </summary>
    public class RefundJsonParser : ITopParser<Refund>
    {
        #region ITopParser<Refund> Members

        public Refund Parse(string body)
        {
            RefundListJsonParser parser = new RefundListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 退款留言列表的JSON响应解释器。
    /// </summary>
    public class RefundMessageListJsonParser : ITopParser<ResponseList<RefundMessage>>
    {
        #region ITopParser<ResponseList<RefundMessage>> Members

        public ResponseList<RefundMessage> Parse(string body)
        {
            return ResponseList<RefundMessage>.ParseJsonResponse("refundMessages", body);
        }

        #endregion
    }

    /// <summary>
    /// 退款留言的JSON响应解释器。
    /// </summary>
    public class RefundMessageJsonParser : ITopParser<RefundMessage>
    {
        #region ITopParser<RefundMessage> Members

        public RefundMessage Parse(string body)
        {
            RefundMessageListJsonParser parser = new RefundMessageListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 确认收货费用列表的JSON响应解释器。
    /// </summary>
    public class ConfirmFeeListJsonParser : ITopParser<ResponseList<ConfirmFee>>
    {
        #region ITopParser<ResponseList<ConfirmFee>> Members

        public ResponseList<ConfirmFee> Parse(string body)
        {
            return ResponseList<ConfirmFee>.ParseJsonResponse("confirmFees", body);
        }

        #endregion
    }

    /// <summary>
    /// 确认收货费用的JSON响应解释器。
    /// </summary>
    public class ConfirmFeeJsonParser : ITopParser<ConfirmFee>
    {
        #region ITopParser<ConfirmFee> Members

        public ConfirmFee Parse(string body)
        {
            ConfirmFeeListJsonParser parser = new ConfirmFeeListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 交易评价列表的JSON响应解释器。
    /// </summary>
    public class TradeRateListJsonParser : ITopParser<ResponseList<TradeRate>>
    {
        #region ITopParser<ResponseList<TradeRate>> Members

        public ResponseList<TradeRate> Parse(string body)
        {
            return ResponseList<TradeRate>.ParseJsonResponse("rates", body);
        }

        #endregion
    }

    /// <summary>
    /// 交易评价的JSON响应解释器。
    /// </summary>
    public class TradeRateJsonParser : ITopParser<TradeRate>
    {
        #region ITopParser<TradeRate> Members

        public TradeRate Parse(string body)
        {
            TradeRateListJsonParser parser = new TradeRateListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
