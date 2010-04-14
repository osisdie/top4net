using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Util;
using System.IO;

namespace Taobao.Top.Api.Test
{
    [TestClass]
    public class SysUtilsTest
    {
        [TestMethod]
        public void SignTopRequest()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("fields", "nick,sex");
            parameters.Add("nick", "winwindg");
            string signature = TopUtils.SignTopRequest(parameters, "carver");
            Assert.AreEqual("E780A69E04E438846FAF25AD28047415", signature);
        }

        [TestMethod]
        public void SignTopRequestWithChineseParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("fields", "nick,sex");
            parameters.Add("nick", "风胜");
            string signature = TopUtils.SignTopRequest(parameters, "carver");
            Assert.AreEqual("C94566A40E066217E83292751B225F2C", signature);
        }

        [TestMethod]
        public void GetMimeTypeByFileName()
        {
            string fileName = "product.jpeg";
            string mimeType = TopUtils.GetMimeType(fileName);
            Assert.AreEqual("image/jpeg", mimeType);
        }

        [TestMethod]
        public void GetMimeTypeByBytes()
        {
            FileInfo fileInfo = TestUtils.GetResourceAsFile("item.jpg");
            byte[] bytes = null;
            using (Stream stream = fileInfo.OpenRead())
            {
                bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
            }
            string mimeType = TopUtils.GetMimeType(bytes);
            Assert.AreEqual("image/jpeg", mimeType);
        }

        [TestMethod]
        public void VerifyTopResponse()
        {
            bool result1 = TopUtils.VerifyTopResponse("http://localhost/test?top_appkey=12007588&top_parameters=aWZyYW1lPTEmdHM9MTI1MjczMzIzODMzOCZ2aWV3X21vZGU9ZnVsbCZ2aWV3X3dpZHRoPTAmdmlzaXRvcl9pZD0xNzU3NTQzNTEmdmlzaXRvcl9uaWNrPWFsaXB1YmxpYzAx&top_session=196494a58aa583729370f3cd1206f9e99&top_sign=QivWleYe9QGId1ZptDl1dw%3D%3D", "2c338829997edb14cf99e73d6ad13f1e");
            Assert.AreEqual(true, result1);

            bool result2 = TopUtils.VerifyTopResponse("http://localhost/test?", "xxx");
            Assert.AreEqual(false, result2);

            bool result3 = TopUtils.VerifyTopResponse("http://localhost/test", "xxx");
            Assert.AreEqual(false, result3);

            bool result4 = TopUtils.VerifyTopResponse("http://localhost/test?a=b", "xxx");
            Assert.AreEqual(false, result4);

            bool result5 = TopUtils.VerifyTopResponse("http://localhost/test?a=b&b=c&d", "xxx");
            Assert.AreEqual(false, result5);

            bool result6 = TopUtils.VerifyTopResponse("aWZyYW1lPTEmdHM9MTI1MjczMzIzODMzOCZ2aWV3X21vZGU9ZnVsbCZ2aWV3X3dpZHRoPTAmdmlzaXRvcl9pZD0xNzU3NTQzNTEmdmlzaXRvcl9uaWNrPWFsaXB1YmxpYzAx", "196494a58aa583729370f3cd1206f9e99", Uri.UnescapeDataString("QivWleYe9QGId1ZptDl1dw%3D%3D"), "12007588", "2c338829997edb14cf99e73d6ad13f1e");
            Assert.AreEqual(true, result6);

            bool result7 = TopUtils.VerifyTopResponse("a", "b", "c", "d", "e");
            Assert.AreEqual(false, result7);
        }

        public void GetTopContext()
        {
            TopContext context = TopUtils.GetTopContext("TOP-10cf2fbe3bf51981521a632698e37cf716kc4HXHnD2ANtGuwsuWktoAeArDbowC-END");
            Assert.AreEqual("12010151", context.AppKey);
            Assert.AreEqual("hz0799", context.UserNick);
        }

        [TestMethod]
        public void DecodeTopParams()
        {
            IDictionary<string, string> dict = TopUtils.DecodeTopParams("aWZyYW1lPTEmdHM9MTI1NjAwNDg5Mzk4MCZ2aWV3X21vZGU9ZnVsbCZ2aWV3X3dpZHRoPTAmdmlzaXRvcl9pZD0yMzQxOTA1NCZ2aXNpdG9yX25pY2s908C649K7yfo%3D");
            Console.WriteLine(dict.Count);
        }
    }
}
