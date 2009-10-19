using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 淘宝应用列表的JSON响应解释器。
    /// </summary>
    public class TadgetListJsonParser : ITopParser<ResponseList<Tadget>>
    {
        #region ITopParser<ResponseList<Tadget>> Members

        public ResponseList<Tadget> Parse(string body)
        {
            return ResponseList<Tadget>.ParseJsonResponse("tadgets", body);
        }

        #endregion
    }

    /// <summary>
    /// 淘宝应用的JSON响应解释器。
    /// </summary>
    public class TadgetJsonParser : ITopParser<Tadget>
    {
        #region ITopParser<Tadget> Members

        public Tadget Parse(string body)
        {
            TadgetListJsonParser parser = new TadgetListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
