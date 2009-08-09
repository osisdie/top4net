using System;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 产品的JSON响应解释器。
    /// </summary>
    public class ProductJsonParser : ITopParser<Product>
    {
        #region ITopParser<Product> Members

        public Product Parse(string body)
        {
            ITopParser<ResponseList<Product>> parser = new ProductListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }


    /// <summary>
    /// 产品列表的JSON响应解释器。
    /// </summary>
    public class ProductListJsonParser : ITopParser<ResponseList<Product>>
    {
        #region ITopParser<ResponseList<Product>> Members

        public ResponseList<Product> Parse(string body)
        {
            return ResponseList<Product>.ParseJsonResponse("products", body);
        }

        #endregion
    }

    /// <summary>
    /// 产品图片的JSON响应解释器。
    /// </summary>
    public class ProductImgJsonParser : ITopParser<ProductImg>
    {
        #region ITopParser<ProductImg> Members

        public ProductImg Parse(string body)
        {
            ProductImgListJsonParser parser = new ProductImgListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 产品图片列表的JSON响应解释器。
    /// </summary>
    public class ProductImgListJsonParser : ITopParser<ResponseList<ProductImg>>
    {
        #region ITopParser<ResponseList<ProductImg>> Members

        public ResponseList<ProductImg> Parse(string body)
        {
            return ResponseList<ProductImg>.ParseJsonResponse("productImgs", body);
        }

        #endregion
    }
}
