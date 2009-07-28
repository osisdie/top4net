using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test
{
    [TestClass]
    public class ProductParserTest
    {
        [TestMethod]
        public void ParseJsonAsProductList()
        {
            ProductListJsonParser parser = new ProductListJsonParser();
            string body = TestUtils.ReadResource("taobao.products.json");
            List<Product> products = parser.Parse(body);
            Assert.AreEqual(2, products.Count);
            AssertResult(products);
        }

        [TestMethod]
        public void ParseXmlAsProductList()
        {
            ProductListXmlParser parser = new ProductListXmlParser();
            string body = TestUtils.ReadResource("taobao.products.xml");
            List<Product> products = parser.Parse(body);
            Assert.AreEqual(2, products.Count);
            AssertResult(products);
        }

        private static void AssertResult(List<Product> products)
        {
            Assert.AreEqual("37342025", products[0].Id);
            Assert.AreEqual("50009211", products[0].CategoryId);
            Assert.AreEqual("408.00", products[0].Price);
            Assert.AreEqual("ECJLXJ", products[0].StandardId);

            Assert.AreEqual("37341712", products[1].Id);
            Assert.AreEqual("50009211", products[1].CategoryId);
            Assert.AreEqual("208.00", products[1].Price);
            Assert.AreEqual("FEKLXJ", products[1].StandardId);
        }
    }
}
