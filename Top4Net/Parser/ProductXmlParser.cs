using System;

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
            ProductListXmlParser parser = new ProductListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 产品列表的XML响应解释器。
    /// </summary>
    public class ProductListXmlParser : ITopParser<ResponseList<Product>>
    {
        #region ITopParser<ResponseList<Product>> Members

        public ResponseList<Product> Parse(string body)
        {
            return ResponseList<Product>.ParseXmlResponse("product", body);
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
            ProductImgListXmlParser parser = new ProductImgListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 产品图片列表的XML响应解释器。
    /// </summary>
    public class ProductImgListXmlParser : ITopParser<ResponseList<ProductImg>>
    {

        #region ITopParser<ResponseList<ProductImg>> Members

        public ResponseList<ProductImg> Parse(string body)
        {
            return ResponseList<ProductImg>.ParseXmlResponse("productImg", body);
        }

        #endregion
    }

    /// <summary>
    /// 产品属性图片的XML响应解释器。
    /// </summary>
    public class ProductPropImgXmlParser : ITopParser<ProductPropImg>
    {
        #region ITopParser<ProductPropImg> Members

        public ProductPropImg Parse(string body)
        {
            ProductPropImgListXmlParser parser = new ProductPropImgListXmlParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 产品属性图片列表的XML响应解释器。
    /// </summary>
    public class ProductPropImgListXmlParser : ITopParser<ResponseList<ProductPropImg>>
    {
        #region ITopParser<ResponseList<ProductPropImg>> Members

        public ResponseList<ProductPropImg> Parse(string body)
        {
            return ResponseList<ProductPropImg>.ParseXmlResponse("productPropImg", body);
        }

        #endregion
    }
}
