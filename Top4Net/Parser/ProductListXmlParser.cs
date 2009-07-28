using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 产品对象的XML响应解释器。
    /// </summary>
    public class ProductListXmlParser : ITopParser<List<Product>>
    {
        #region ITopParser<List<Product>> Members

        public List<Product> Parse(string body)
        {
            // 重写User类型的XML标签名称
            XmlAttributes attrs = new XmlAttributes();
            attrs.XmlElements.Add(new XmlElementAttribute("product", typeof(Product)));

            // 重写UserListResponse类型里面的Users属性的标签名称
            XmlAttributeOverrides attrOvrs = new XmlAttributeOverrides();
            attrOvrs.Add(typeof(ProductListResponse), "Products", attrs);

            XmlSerializer serializer = new XmlSerializer(typeof(ProductListResponse), attrOvrs);

            object obj = serializer.Deserialize(new StringReader(body));
            ProductListResponse ulr = obj as ProductListResponse;
            return ulr == null ? null : ulr.Products;
        }

        #endregion

        /// <summary>
        /// 产品列表响应，用于XML反序列化。
        /// </summary>
        [Serializable]
        [XmlRoot("rsp")]
        public class ProductListResponse
        {
            public List<Product> Products { get; set; }
        }
    }
}
