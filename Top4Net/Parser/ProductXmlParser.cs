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
            XmlAttributeOverrides attrs = Response<Product>.GetOverrides("product");
            XmlSerializer serializer = new XmlSerializer(typeof(Response<Product>), attrs);

            object obj = serializer.Deserialize(new StringReader(body));
            Response<Product> rsp = obj as Response<Product>;
            return rsp == null ? null : rsp.Content;
        }

        #endregion
    }

    /// <summary>
    /// 产品列表的XML响应解释器。
    /// </summary>
    public class ProductListXmlParser : ITopParser<List<Product>>
    {
        #region ITopParser<List<Product>> Members

        public List<Product> Parse(string body)
        {
            XmlAttributeOverrides attrs = ResponseList<Product>.GetOverrides("product");
            XmlSerializer serializer = new XmlSerializer(typeof(ResponseList<Product>), attrs);

            object obj = serializer.Deserialize(new StringReader(body));
            ResponseList<Product> rsp = obj as ResponseList<Product>;
            return rsp == null ? null : rsp.Content;
        }

        #endregion
    }

    /// <summary>
    /// 产品图片的XML响应解释器。
    /// </summary>
    public class ProductImgXmlParser : ITopParser<ProductImg>
    {
        #region ITopParser<ProductImg> Members

        public ProductImg Parse(string body)
        {
            XmlAttributeOverrides attrs = Response<ProductImg>.GetOverrides("productImg");
            XmlSerializer serializer = new XmlSerializer(typeof(Response<ProductImg>), attrs);

            object obj = serializer.Deserialize(new StringReader(body));
            Response<ProductImg> rsp = obj as Response<ProductImg>;
            return rsp == null ? null : rsp.Content;
        }

        #endregion
    }
}
