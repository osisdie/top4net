using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Test
{
    [TestClass]
    public class EncryptUtilsTest
    {
        [TestMethod]
        public void SignTopRequest()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("fields", "nick,sex");
            parameters.Add("nick", "winwindg");
            string signature = EncryptUtils.SignTopRequest(parameters, "carver");
            Assert.AreEqual("E780A69E04E438846FAF25AD28047415", signature);
        }
    }
}
