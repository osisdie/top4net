using System;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 不做任何处理，直接返回字符串的解释器。
    /// </summary>
    public class StringParser : ITopParser<string>
    {
        #region ITopParser<string> Members

        public string Parse(string body)
        {
            return body;
        }

        #endregion
    }
}
