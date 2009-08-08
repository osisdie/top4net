using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 产品的XML响应解释器。
    /// </summary>
    public class ProductXmlParser : ITopParser<Product>
    {
        #region ITopParser<Product> Members

        public Product Parse(string body)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ProductRsp));

            object obj = serializer.Deserialize(new StringReader(body));
            ProductRsp rsp = obj as ProductRsp;
            return rsp == null ? null : rsp.Product;
        }

        #endregion

        /// <summary>
        /// 产品响应类，用于XML反序列化。
        /// </summary>
        [Serializable]
        [XmlRoot("rsp")]
        public class ProductRsp
        {
            [XmlElement("product")]
            public Product Product { get; set; }
        }
    }

    /// <summary>
    /// 产品列表的XML响应解释器。
    /// </summary>
    public class ProductListXmlParser : ITopParser<List<Product>>
    {
        #region ITopParser<List<Product>> Members

        public List<Product> Parse(string body)
        {
            // 重写Product类型的XML标签名称
            XmlAttributes attrs = new XmlAttributes();
            attrs.XmlElements.Add(new XmlElementAttribute("product", typeof(Product)));

            // 重写ProductListResponse类型里面的Products属性的标签名称
            XmlAttributeOverrides attrOvrs = new XmlAttributeOverrides();
            attrOvrs.Add(typeof(ProductListRsp), "Products", attrs);

            XmlSerializer serializer = new XmlSerializer(typeof(ProductListRsp), attrOvrs);

            object obj = serializer.Deserialize(new StringReader(body));
            ProductListRsp rsp = obj as ProductListRsp;
            return rsp == null ? null : rsp.Products;
        }

        #endregion

        /// <summary>
        /// 产品列表响应，用于XML反序列化。
        /// </summary>
        [Serializable]
        [XmlRoot("rsp")]
        public class ProductListRsp
        {
            public List<Product> Products { get; set; }
        }
    }

    /// <summary>
    /// 产品图片的XML响应解释器。
    /// </summary>
    public class ProductImgXmlParser : ITopParser<ProductImg>
    {
        #region ITopParser<ProductImg> Members

        public ProductImg Parse(string body)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ProductImgRsp));
            object obj = serializer.Deserialize(new StringReader(body));
            return (obj as ProductImgRsp).ProductImg;
        }

        #endregion

        /// <summary>
        /// 产品图片响应类，用于XML反序列化。
        /// </summary>
        [Serializable]
        [XmlRoot("rsp")]
        public class ProductImgRsp
        {
            [XmlElement("productImg")]
            public ProductImg ProductImg { get; set; }
        }
    }
}
