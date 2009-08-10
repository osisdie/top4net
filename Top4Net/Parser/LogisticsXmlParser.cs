using System;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
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
}
