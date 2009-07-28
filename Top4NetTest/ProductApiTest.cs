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
    }
}
