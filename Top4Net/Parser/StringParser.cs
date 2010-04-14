namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 不作任何处理，直接返回响应字符串。
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
