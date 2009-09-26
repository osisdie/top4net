using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Test.Util
{
    [TestClass]
    public class FileItemTest
    {
        [TestMethod]
        public void CreateFileItem()
        {
            try
            {
                FileItem fileItem = new FileItem(null);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e is ArgumentException);
            }
        }

        [TestMethod]
        public void GetMimeType()
        {
            FileItem fileItem = TestUtils.GetResourceAsFileItem("item.jpg");
            Assert.AreEqual("image/jpeg", fileItem.GetMimeType());
        }
    }
}
