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
            string body = TestUtils.GetResourceAsText("products.json");
            ResponseList<Product> products = parser.Parse(body);
            Assert.AreEqual(919, products.TotalResults);
            Assert.AreEqual(2, products.Content.Count);
            AssertProduct(products.Content);
        }

        [TestMethod]
        public void ParseXmlAsProductList()
        {
            ProductListXmlParser parser = new ProductListXmlParser();
            string body = TestUtils.GetResourceAsText("products.xml");
            ResponseList<Product> products = parser.Parse(body);
            Assert.AreEqual(919, products.TotalResults);
            Assert.AreEqual(2, products.Content.Count);
            AssertProduct(products.Content);
        }

        [TestMethod]
        public void ParseJsonAsProductImg()
        {
            ProductImgJsonParser parser = new ProductImgJsonParser();
            string body = TestUtils.GetResourceAsText("product.image.json");
            ProductImg productImg = parser.Parse(body);
            AssertProductImg(productImg);
        }

        [TestMethod]
        public void ParseXmlAsProductImg()
        {
            ProductImgXmlParser parser = new ProductImgXmlParser();
            string body = TestUtils.GetResourceAsText("product.image.xml");
            ProductImg productImg = parser.Parse(body);
            AssertProductImg(productImg);
        }

        private static void AssertProduct(List<Product> products)
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

        private void AssertProductImg(ProductImg productImg)
        {
            Assert.AreEqual("2009-08-04 21:43:14", productImg.Created);
            Assert.AreEqual("2009-08-04 21:43:14", productImg.Modified);
            Assert.AreEqual("380745", productImg.ImgId);
            Assert.AreEqual("http://img06.taobao.net/bao/uploaded/i6/T1CpXXXg7KutMoEn_a_092459.jpg", productImg.ImgUrl);
        }
    }
}
