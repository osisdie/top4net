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
            TopResponse<Product> topRsp = new TopResponse<Product>("product");
            XmlSerializer serializer = new XmlSerializer(typeof(TopResponse<Product>), topRsp.GetOverrides());

            object obj = serializer.Deserialize(new StringReader(body));
            TopResponse<Product> rsp = obj as TopResponse<Product>;
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
            TopListResponse<Product> topRsp = new TopListResponse<Product>("product");
            XmlSerializer serializer = new XmlSerializer(typeof(TopListResponse<Product>), topRsp.GetOverrides());

            object obj = serializer.Deserialize(new StringReader(body));
            TopListResponse<Product> rsp = obj as TopListResponse<Product>;
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
            TopResponse<ProductImg> topRsp = new TopResponse<ProductImg>("productImg");
            XmlSerializer serializer = new XmlSerializer(typeof(TopResponse<ProductImg>), topRsp.GetOverrides());

            object obj = serializer.Deserialize(new StringReader(body));
            TopResponse<ProductImg> rsp = obj as TopResponse<ProductImg>;
            return rsp == null ? null : rsp.Content;
        }

        #endregion
    }
}
