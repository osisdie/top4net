using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// 上传一个产品。
    /// </summary>
    public class ProductAddRequest : ITopUploadRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 产品名称。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 产品市场价。
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 产品描述。
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 类目编号。
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// 外部产品编号。
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 关键属性列表。
        /// </summary>
        public string PropList { get; set; }

        /// <summary>
        /// 绑定属性（非关键）属性列表。
        /// </summary>
        public string BindPropList { get; set; }

        /// <summary>
        /// 销售属性列表。
        /// </summary>
        public string SalePropList { get; set; }

        /// <summary>
        /// 自定义属性列表。
        /// </summary>
        public string CustomPropList { get; set; }

        /// <summary>
        /// 图片绝对地址。
        /// </summary>
        public string Image { get; set; }

        public ProductAddRequest(string sessionKey)
        {
            this.sessionKey = sessionKey;
        }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("name", Name);
            parameters.Add("price", Price);
            parameters.Add("desc", Description);
            parameters.Add("cid", CategoryId);
            parameters.Add("outer_id", OuterId);
            parameters.Add("props", PropList);
            parameters.Add("binds", BindPropList);
            parameters.Add("sale_props", SalePropList);
            parameters.Add("customer_props", CustomPropList);

            return parameters;
        }

        #endregion

        #region ITopPrivateRequest Members

        public string GetSessionKey()
        {
            return this.sessionKey;
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, string> GetFileParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("image", this.Image);

            return parameters;
        }

        #endregion
    }
}
