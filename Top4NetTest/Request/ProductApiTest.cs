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
        private Product _product;

        [TestInitialize]
        public void Initialize()
        {
            _product = AddProduct();
        }

        [TestCleanup]
        public void Cleanup()
        {
        }

        [TestMethod]
        public void GetProductByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ProductGetRequest req = new ProductGetRequest();
            req.Fields = "name,cid,props,props_str,name,binds,created";
            req.Cid = _product.CategoryId;
            req.Props = _product.Props;
            Product product = client.Execute(req, new ProductJsonParser());
            Assert.IsNotNull(product);
        }

        [TestMethod]
        public void GetProductByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ProductGetRequest req = new ProductGetRequest();
            req.Fields = "name,cid,props,props_str,name,binds,created";
            req.ProductId = _product.Id;
            Product product = client.Execute(req, new ProductXmlParser());
            Assert.IsNotNull(product);
        }

        [TestMethod]
        public void SearchProductsByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ProductsSearchRequest req = new ProductsSearchRequest();
            req.Fields = "product_id,name,pic_patch,cid,props,price,modified";
            req.Query = "Nokia N73";
            req.PageNo = 1;
            req.PageSize = 10;
            ResponseList<Product> rsp = client.Execute(req, new ProductListJsonParser());
            Assert.IsNotNull(rsp);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void SearchProductsByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ProductsSearchRequest req = new ProductsSearchRequest();
            req.Fields = "product_id,name,pic_patch,cid,props,price,modified,tsc";
            req.Query = "N73";
            req.PageNo = 2;
            req.PageSize = 5;
            ResponseList<Product> rsp = client.Execute(req, new ProductListXmlParser());
            Assert.IsNotNull(rsp);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetProductsByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ProductsGetRequest req = new ProductsGetRequest();
            req.Fields = "name,cid,props,props_str,name,binds,created";
            req.Nick = "tbtest561";
            req.PageNo = 1;
            req.PageSize = 10;
            ResponseList<Product> rsp = client.Execute(req, new ProductListJsonParser());
            Assert.IsNotNull(rsp);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void GetProductsByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ProductsGetRequest req = new ProductsGetRequest();
            req.Fields = "name,cid,props,props_str,name,binds,created";
            req.Nick = "b2ctest125";
            req.PageNo = 1;
            req.PageSize = 5;
            ResponseList<Product> rsp = client.Execute(req, new ProductListXmlParser());
            Assert.IsNotNull(rsp);
            Assert.IsTrue(rsp.Content.Count > 0);
        }

        [TestMethod]
        public void UploadProductImageByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ProductImgUploadRequest req = new ProductImgUploadRequest();
            req.ProductId = _product.Id;
            req.Image = TestUtils.GetResourceAsFile("product.jpg");
            req.Position = 1;

            ITopRequest proxy = new TopUploadRequestProxy(req, "b2ctest125");
            ProductImg rsp = client.Execute(proxy, new ProductImgJsonParser());
            Assert.IsNotNull(rsp);

            DeleteProductImg(_product.Id, rsp.ImgId);
        }

        [TestMethod]
        public void UploadProductImageByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ProductImgUploadRequest req = new ProductImgUploadRequest();
            req.ProductId = _product.Id;
            req.Image = TestUtils.GetResourceAsFile("product.jpg");
            req.Position = 2;

            ITopRequest proxy = new TopUploadRequestProxy(req, "b2ctest125");
            ProductImg rsp = client.Execute(proxy, new ProductImgXmlParser());
            Assert.IsNotNull(rsp);

            DeleteProductImg(_product.Id, rsp.ImgId);
        }

        [TestMethod]
        public void UploadProductPropImgByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ProductPropImgUploadRequest req = new ProductPropImgUploadRequest();
            req.ProductId = _product.Id;
            req.Props = "1627207:3232483";
            req.Image = TestUtils.GetResourceAsFile("prop.jpg");
            ITopRequest proxy = new TopUploadRequestProxy(req, "b2ctest125");
            ProductPropImg rsp = client.Execute(proxy, new ProductPropImgJsonParser());
            Assert.IsNotNull(rsp);

            DeleteProductPropImg(_product.Id, rsp.ImgId);
        }

        [TestMethod]
        public void UploadProductPropImgByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ProductPropImgUploadRequest req = new ProductPropImgUploadRequest();
            req.ProductId = _product.Id;
            req.Props = "1627207:3232484";
            req.Image = TestUtils.GetResourceAsFile("prop.jpg");
            ITopRequest proxy = new TopUploadRequestProxy(req, "b2ctest125");
            ProductPropImg rsp = client.Execute(proxy, new ProductPropImgXmlParser());
            Assert.IsNotNull(rsp);

            DeleteProductPropImg(_product.Id, rsp.ImgId);
        }

        [TestMethod]
        public void UpdateProductByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ProductUpdateRequest req = new ProductUpdateRequest();
            req.ProductId = _product.Id;
            req.Name = "诺基亚机皇JSON";
            ITopRequest proxy = new TopRequestProxy(req, "b2ctest125");
            Product product = client.Execute(proxy, new ProductJsonParser());
            Assert.IsNotNull(product);
            Assert.AreEqual(_product.Id, product.Id);
        }

        [TestMethod]
        public void UpdateProductByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ProductUpdateRequest req = new ProductUpdateRequest();
            req.ProductId = _product.Id;
            req.Name = "诺基亚机皇XML";
            ITopRequest proxy = new TopRequestProxy(req, "b2ctest125");
            Product product = client.Execute(proxy, new ProductXmlParser());
            Assert.IsNotNull(product);
            Assert.AreEqual(_product.Id, product.Id);
        }

        [TestMethod]
        public void DeleteProductImgByJson()
        {
            ProductImg oldImg = UploadProductImg();

            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ProductImgDeleteRequest req = new ProductImgDeleteRequest();
            req.ProductId = oldImg.ProductId;
            req.ImgId = oldImg.ImgId;
            ITopRequest proxy = new TopRequestProxy(req, "b2ctest125");
            ProductImg img = client.Execute(proxy, new ProductImgJsonParser());
            Assert.AreEqual(oldImg.ProductId, img.ProductId);
            Assert.AreEqual(oldImg.ImgId, img.ImgId);
        }

        [TestMethod]
        public void DeleteProductImgByXml()
        {
            ProductImg oldImg = UploadProductImg();

            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ProductImgDeleteRequest req = new ProductImgDeleteRequest();
            req.ProductId = oldImg.ProductId;
            req.ImgId = oldImg.ImgId;
            ITopRequest proxy = new TopRequestProxy(req, "b2ctest125");
            ProductImg img = client.Execute(proxy, new ProductImgXmlParser());
            Assert.AreEqual(null, img.ProductId);
            Assert.AreEqual(oldImg.ImgId, img.ImgId);
        }

        [TestMethod]
        public void DeleteProductPropImgByJson()
        {
            ProductPropImg oldImg = UploadProductPropImg();

            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ProductPropImgDeleteRequest req = new ProductPropImgDeleteRequest();
            req.ProductId = oldImg.ProductId;
            req.ImgId = oldImg.ImgId;
            ITopRequest proxy = new TopRequestProxy(req, "b2ctest125");
            ProductPropImg img = client.Execute(proxy, new ProductPropImgJsonParser());
            Assert.IsNotNull(img);
        }

        [TestMethod]
        public void DeleteProductPropImgByXml()
        {
            ProductPropImg oldImg = UploadProductPropImg();

            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            ProductPropImgDeleteRequest req = new ProductPropImgDeleteRequest();
            req.ProductId = oldImg.ProductId;
            req.ImgId = oldImg.ImgId;
            ITopRequest proxy = new TopRequestProxy(req, "b2ctest125");
            ProductPropImg img = client.Execute(proxy, new ProductPropImgXmlParser());
            Assert.IsNotNull(img);
        }

        private Product AddProduct()
        {
            Product oldProduct = GetProduct();
            if (oldProduct != null)
            {
                return oldProduct;
            }

            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ProductAddRequest request = new ProductAddRequest();
            request.Name = "Nokia N73";
            request.Price = "3000.00";
            request.Desc = "Nokia N73, Cool";
            request.Cid = "50012286";
            request.Props = "1637400:4606395;21862:31578;21861:3683581";
            request.Image = TestUtils.GetResourceAsFile("product.jpg");

            ITopRequest proxy = new TopUploadRequestProxy(request, "b2ctest125");
            return client.Execute(proxy, new ProductJsonParser());
        }

        private Product GetProduct()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ProductGetRequest request = new ProductGetRequest();
            request.Fields = "product_id,name,cid,props,props_str,name,binds,created";
            request.Cid = "50012286";
            request.Props = "21862:31578;21861:3683581";
            return client.Execute(request, new ProductJsonParser());
        }

        private ProductImg UploadProductImg()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ProductImgUploadRequest req = new ProductImgUploadRequest();
            req.ProductId = _product.Id;
            req.Image = TestUtils.GetResourceAsFile("product.jpg");
            req.Position = 3;

            ITopRequest proxy = new TopUploadRequestProxy(req, "b2ctest125");
            ProductImg img = client.Execute(proxy, new ProductImgJsonParser());
            img.ProductId = _product.Id;
            return img;
        }

        private void DeleteProductImg(string productId, string imgId)
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ProductImgDeleteRequest req = new ProductImgDeleteRequest();
            req.ProductId = productId;
            req.ImgId = imgId;
            ITopRequest proxy = new TopRequestProxy(req, "b2ctest125");
            ProductImg rsp = client.Execute(proxy, new ProductImgJsonParser());
            Assert.IsNotNull(rsp);
        }

        private ProductPropImg UploadProductPropImg()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ProductPropImgUploadRequest req = new ProductPropImgUploadRequest();
            req.ProductId = _product.Id;
            req.Props = "1627207:3232483";
            req.Image = TestUtils.GetResourceAsFile("prop.jpg");
            ITopRequest proxy = new TopUploadRequestProxy(req, "b2ctest125");
            ProductPropImg img = client.Execute(proxy, new ProductPropImgJsonParser());
            img.ProductId = _product.Id;
            return img;
        }

        private void DeleteProductPropImg(string productId, string propImgId)
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            ProductPropImgDeleteRequest req = new ProductPropImgDeleteRequest();
            req.ProductId = productId;
            req.ImgId = propImgId;
            ITopRequest proxy = new TopRequestProxy(req, "b2ctest125");
            ProductPropImg rsp = client.Execute(proxy, new ProductPropImgJsonParser());
            Assert.IsNotNull(rsp);
        }
    }
}
