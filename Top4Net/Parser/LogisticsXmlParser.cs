using System;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 物流订单列表的XML响应解释器。
    /// </summary>
    public class LogisticsOrderListXmlParser : ITopParser<ResponseList<LogisticsOrder>>
    {
        #region ITopParser<ResponseList<Logistics>> Members

        public ResponseList<LogisticsOrder> Parse(string body)
        {
            return ResponseList<LogisticsOrder>.ParseXmlResponse("ship", body);
        }

        #endregion
    }

    /// <summary>
    /// 物流订单的XML响应解释器。
    /// </summary>
    public class LogisticsOrderXmlParser : ITopParser<LogisticsOrder>
    {
        #region ITopParser<Logistics> Members

        public LogisticsOrder Parse(string body)
        {
            LogisticsOrderListXmlParser parser = new LogisticsOrderListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 物流公司列表的XML响应解释器。
    /// </summary>
    public class LogisticsCompanyListXmlParser : ITopParser<ResponseList<LogisticsCompany>>
    {
        #region ITopParser<ResponseList<LogisticsCompany>> Members

        public ResponseList<LogisticsCompany> Parse(string body)
        {
            return ResponseList<LogisticsCompany>.ParseXmlResponse("logistic_company", body);
        }

        #endregion
    }

    /// <summary>
    /// 物流公司的XML响应解释器。
    /// </summary>
    public class LogisticsCompanyXmlParser : ITopParser<LogisticsCompany>
    {
        #region ITopParser<LogisticsCompany> Members

        public LogisticsCompany Parse(string body)
        {
            LogisticsCompanyListXmlParser parser = new LogisticsCompanyListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 地址区域列表的XML响应解释器。
    /// </summary>
    public class AreaListXmlParser : ITopParser<ResponseList<Area>>
    {
        #region ITopParser<ResponseList<Area>> Members

        public ResponseList<Area> Parse(string body)
        {
            return ResponseList<Area>.ParseXmlResponse("area", body);
        }

        #endregion
    }

    /// <summary>
    /// 地址区域的XML响应解释器。
    /// </summary>
    public class AreaXmlParser : ITopParser<Area>
    {
        #region ITopParser<Area> Members

        public Area Parse(string body)
        {
            AreaListXmlParser parser = new AreaListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 买家收货地址列表的XML响应解释器。
    /// </summary>
    public class ShippingAddressListXmlParser : ITopParser<ResponseList<ShippingAddress>>
    {
        #region ITopParser<ResponseList<ShippingAddress>> Members

        public ResponseList<ShippingAddress> Parse(string body)
        {
            return ResponseList<ShippingAddress>.ParseXmlResponse("shippingAddress", body);
        }

        #endregion
    }

    /// <summary>
    /// 买家收货地址的XML响应解释器。
    /// </summary>
    public class ShippingAddressXmlParser : ITopParser<ShippingAddress>
    {
        #region ITopParser<ShippingAddress> Members

        public ShippingAddress Parse(string body)
        {
            ShippingAddressListXmlParser parser = new ShippingAddressListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
