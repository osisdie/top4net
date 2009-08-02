using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Test
{
    /// <summary>
    /// 测试用工具类。
    /// </summary>
    public abstract class TestUtils
    {
        private const string TOP_AUTHORIZE_URL = "http://open.taobao.com/isv/authorize.php";
        private const string TOP_CONTAINER_URL = "http://container.sandbox.taobao.com/container";

        public static ITopClient GetTestTopClient(string format)
        {
            return new TopRestClient("http://gw.sandbox.taobao.com/router/rest", "sns", "sns", format);
        }

        public static ITopClient GetProductTopClient(string format)
        {
            return new TopRestClient("http://gw.api.taobao.com/router/rest", "10011201", "10011201", format);
        }

        public static string ReadResource(string fileName)
        {
            return File.ReadAllText("../../../Top4NetTest/Resources/" + fileName, Encoding.UTF8);
        }

        /// <summary>
        /// 获取用户会话授权码。
        /// </summary>
        /// <param name="appKey">应用码</param>
        /// <param name="nick">用户昵称</param>
        /// <returns>用户会话授权码</returns>
        public static string GetSessionKey(string appKey, string nick)
        {
            IDictionary<string, string> authCodeParams = new Dictionary<string, string>();
            authCodeParams.Add("appkey", appKey);
            authCodeParams.Add("nick", nick);

            string authCodeRsp = WebUtils.DoPost(TOP_AUTHORIZE_URL, authCodeParams);
            string authCodePattern = "<input type=\"text\" id=\"autoInput\" value=\"(.+?)\" style=\".+?\">";
            Match authCodeResult = Regex.Match(authCodeRsp, authCodePattern);
            string authCode = authCodeResult.Groups[1].Value;

            IDictionary<string, string> sessionParams = new Dictionary<string, string>();
            sessionParams.Add("authcode", Uri.UnescapeDataString(authCode));
            string sessionRsp = WebUtils.DoGet(TOP_CONTAINER_URL, sessionParams);

            string sessionPattern = "&top_session=(\\w+?)&";
            Match sessionResult = Regex.Match(sessionRsp, sessionPattern);
            string sessionKey = sessionResult.Groups[1].Value;

            return sessionKey;
        }
    }
}
