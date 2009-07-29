using System;
using System.IO;
using System.Xml.Serialization;

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
            XmlSerializer serializer = new XmlSerializer(typeof(ProductResponse));

            object obj = serializer.Deserialize(new StringReader(body));
            ProductResponse pr = obj as ProductResponse;
            return pr == null ? null : pr.Product;
        }

        #endregion

        /// <summary>
        /// 产品响应类，用于XML反序列化。
        /// </summary>
        [Serializable]
        [XmlRoot("rsp")]
        public class ProductResponse
        {
            [XmlElement("product")]
            public Product Product { get; set; }
        }
    }
}
