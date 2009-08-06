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
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            ProductsSearchRequest request = new ProductsSearchRequest();
            request.Fields = "product_id,name,pic_patch,cid,props,price,modified";
            request.Query = "N73";
            request.PageNo = "1";
            request.PageSize = "3";
            List<Product> products = client.Execute(request, new ProductListJsonParser());

            Assert.AreEqual(3, products.Count);
        }

        [TestMethod]
        public void SearchProductsByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            ProductsSearchRequest request = new ProductsSearchRequest();
            request.Fields = "product_id,name,pic_patch,cid,props,price,modified,tsc";
            request.Query = "N73";
            request.PageNo = "2";
            request.PageSize = "5";
            List<Product> products = client.Execute(request, new ProductListXmlParser());

            Assert.AreEqual(5, products.Count);
        }

        [TestMethod]
        public void GetProductByJson()
        {
            ITopClient client = TestUtils.GetProductTopClient("json");
            ProductGetRequest request = new ProductGetRequest();
            request.Fields = "name,cid,props,props_str,name,binds,created";
            request.ProductId = "38982136";
            Product product = client.Execute(request, new ProductJsonParser());

            Assert.IsNotNull(product);
            Assert.AreEqual("50012587", product.CategoryId);
        }

        [TestMethod]
        public void GetProductByXml()
        {
            ITopClient client = TestUtils.GetProductTopClient("xml");
            ProductGetRequest request = new ProductGetRequest();
            request.Fields = "name,cid,props,props_str,name,binds,created";
            request.ProductId = "38982136";
            Product product = client.Execute(request, new ProductXmlParser());

            Assert.IsNotNull(product);
            Assert.AreEqual("50012587", product.CategoryId);
        }

        [TestMethod]
        public void GetProductsByJson()
        {
            ITopClient client = TestUtils.GetProductTopClient("json");
            ProductsGetRequest request = new ProductsGetRequest();
            request.Fields = "name,cid,props,props_str,name,binds,created";
            request.Nick = "驴友之家";
            List<Product> products = client.Execute(request, new ProductListJsonParser());

            Assert.AreEqual(1, products.Count);
        }

        [TestMethod]
        public void GetProductsByXml()
        {
            ITopClient client = TestUtils.GetProductTopClient("xml");
            ProductsGetRequest request = new ProductsGetRequest();
            request.Fields = "name,cid,props,props_str,name,binds,created";
            request.Nick = "驴友之家";
            List<Product> products = client.Execute(request, new ProductListXmlParser());

            Assert.AreEqual(1, products.Count);
        }

        //[TestMethod]
        public void AddProductByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ProductAddRequest request = new ProductAddRequest();
            request.Name = "Nokia N73";
            request.Price = "3000.00";
            request.Desc = "Nokia N73, Cool";
            request.Cid = "50012286";
            request.Props = "1637400:4606395;21862:31578;21861:3683581";
            request.Image = TestUtils.GetResourceAsFile("product.jpg");

            ITopRequest proxy = new TopRequestProxy(request, "b2ctest125");
            List<Product> products = client.Execute(proxy, new ProductListJsonParser());
        }

        //[TestMethod]
        public void UploadProductImage()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ProductImgUploadRequest request = new ProductImgUploadRequest();
            request.ProductId = "203940";
            request.Image = TestUtils.GetResourceAsFile("product.jpg");
            request.Position = "7";

            ITopRequest proxy = new TopRequestProxy(request, "admin");
            string response = client.Execute(proxy, new StringParser());
            Console.WriteLine(response);
        }
    }
}
