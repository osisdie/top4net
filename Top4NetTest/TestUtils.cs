using System;
using System.IO;
using System.Text;

namespace Taobao.Top.Api.Test
{
    /// <summary>
    /// 测试用工具类。
    /// </summary>
    public abstract class TestUtils
    {
        public static ITopClient GetTestTopClient(string format)
        {
            return new TopRestClient("http://gw.sandbox.taobao.com/router/rest", "test", "test", format);
        }

        public static ITopClient GetProductTopClient(string format)
        {
            return new TopRestClient("http://gw.api.taobao.com/router/rest", "10011201", "10011201", format);
        }

        public static string ReadResource(string fileName)
        {
            return File.ReadAllText("../../../Top4NetTest/Resources/" + fileName, Encoding.UTF8);
        }
    }
}
