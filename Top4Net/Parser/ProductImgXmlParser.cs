using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 产品图片的XML响应解释器。
    /// </summary>
    public class ProductImgXmlParser : ITopParser<ProductImg>
    {
        #region ITopParser<ProductImg> Members

        public ProductImg Parse(string body)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ProductImgResponse));
            object obj = serializer.Deserialize(new StringReader(body));
            return (obj as ProductImgResponse).ProductImg;
        }

        #endregion

        /// <summary>
        /// 用户响应类，用于XML反序列化。
        /// </summary>
        [Serializable]
        [XmlRoot("rsp")]
        public class ProductImgResponse
        {
            [XmlElement("productImg")]
            public ProductImg ProductImg { get; set; }
        }
    }
}
