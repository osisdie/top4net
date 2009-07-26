using System;
using System.IO;
using System.Text;

namespace Taobao.Top.Api.Test
{
    public abstract class TestUtils
    {
        public static string readResource(string fileName)
        {
            return File.ReadAllText("../../../Top4NetTest/Resources/" + fileName, Encoding.UTF8);
        }
    }
}
