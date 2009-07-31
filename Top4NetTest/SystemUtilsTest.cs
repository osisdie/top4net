using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Test
{
    [TestClass]
    public class SystemUtilsTest
    {
        [TestMethod]
        public void SignTopRequest()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("fields", "nick,sex");
            parameters.Add("nick", "winwindg");
            string signature = SystemUtils.SignTopRequest(parameters, "carver");
            Assert.AreEqual("E780A69E04E438846FAF25AD28047415", signature);
        }

        [TestMethod]
        public void SignTopRequestWithChineseParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("fields", "nick,sex");
            parameters.Add("nick", "风胜");
            string signature = SystemUtils.SignTopRequest(parameters, "carver");
            Assert.AreEqual("C94566A40E066217E83292751B225F2C", signature);
        }
    }
}
