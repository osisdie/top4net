using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 淘宝应用列表的XML响应解释器。
    /// </summary>
    public class TadgetListXmlParser : ITopParser<ResponseList<Tadget>>
    {
        #region ITopParser<ResponseList<Tadget>> Members

        public ResponseList<Tadget> Parse(string body)
        {
            return ResponseList<Tadget>.ParseXmlResponse("tadgets", body);
        }

        #endregion
    }

    /// <summary>
    /// 淘宝应用的XML响应解释器。
    /// </summary>
    public class TadgetXmlParser : ITopParser<Tadget>
    {
        #region ITopParser<Tadget> Members

        public Tadget Parse(string body)
        {
            TadgetListXmlParser parser = new TadgetListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
