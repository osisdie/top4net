using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Parser;

namespace Taobao.Top.Api.Test
{
    [TestClass]
    public class ProductApiTest
    {
        [TestMethod]
        public void SearchProductsByJson()
        {
            ITopClient client = TestUtils.GetTestTopClient("json");
            ProductsSearchRequest request = new ProductsSearchRequest();
            request.Fields = "product_id,name,pic_patch,cid,props,price,modified,tsc";
            request.Query = "N73";
            request.PageSize = 10;
            List<Product> products = client.Execute(request, new ProductListJsonParser());
            Assert.AreEqual(0, products.Count);
        }

        [TestMethod]
        public void SearchProductsByXml()
        {
            ITopClient client = TestUtils.GetTestTopClient("xml");
            ProductsSearchRequest request = new ProductsSearchRequest();
            request.Fields = "product_id,name,pic_patch,cid,props,price,modified,tsc";
            request.Query = "N73";
            request.PageSize = 10;
            List<Product> products = client.Execute(request, new ProductListXmlParser());
            Assert.AreEqual(0, products.Count);
        }

        [TestMethod]
        public void GetProductByJson()
        {
            ITopClient client = TestUtils.GetInternalTopClient("json");
            ProductGetRequest request = new ProductGetRequest();
            request.Fields = "name,cid,props,props_str,name,binds,created";
            request.ProductId = "84510855";
            Product product = client.Execute(request, new ProductJsonParser());
            AssertProduct(product);
        }

        [TestMethod]
        public void GetProductByXml()
        {
            ITopClient client = TestUtils.GetInternalTopClient("xml");
            ProductGetRequest request = new ProductGetRequest();
            request.Fields = "name,cid,props,props_str,name,binds,created";
            request.ProductId = "84510855";
            Product product = client.Execute(request, new ProductXmlParser());
            AssertProduct(product);
        }

        private void AssertProduct(Product product)
        {
            Assert.AreEqual("50010850", product.CategoryId);
            Assert.AreEqual("2009-06-11 13:57:32", product.CreatedStr);
            Assert.AreEqual("20000:3716986", product.PropList);
        }

        [TestMethod]
        public void GetProductsByJson()
        {
            ITopClient client = TestUtils.GetInternalTopClient("json");
            ProductsGetRequest request = new ProductsGetRequest();
            request.Fields = "name,cid,props,props_str,name,binds,created";
            request.Nick = "tbtest";
            List<Product> products = client.Execute(request, new ProductListJsonParser());
            Assert.AreEqual(1, products.Count);
        }

        [TestMethod]
        public void GetProductsByXml()
        {
            ITopClient client = TestUtils.GetInternalTopClient("xml");
            ProductsGetRequest request = new ProductsGetRequest();
            request.Fields = "name,cid,props,props_str,name,binds,created";
            request.Nick = "tbtest";
            List<Product> products = client.Execute(request, new ProductListXmlParser());
            Assert.AreEqual(1, products.Count);
        }

        //[TestMethod]
        public void AddProductAsJson()
        {
            ITopClient client = TestUtils.GetInternalTopClient("xml");
            ProductAddRequest request = new ProductAddRequest("109e96817a924395e281f76de5ce597a0");
            request.Name = "Nokia N73";
            request.Price = "3000.00";
            request.Description = "Nokia N73, Cool";
            request.CategoryId = "50008165";
            request.OuterId = "200612";
            request.PropList = "20000:30812;1632501:31578;21861:3683581";
            request.BindPropList = "1637400:4606395;21862:31578";
            request.SalePropList = "1627207:28324";
            request.CustomPropList = "21861:MyValue";
            string result = client.Execute(request, new StringParser());
            Console.WriteLine(result);
        }
    }
}
