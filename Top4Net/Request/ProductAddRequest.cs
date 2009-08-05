using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.add
    /// </summary>
    public class ProductAddRequest : ITopUploadRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 类目ID。
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// 外部产品ID。
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 关键属性pid:vid;pid:vid ,如果碰到用户自定义属性，请用customer_props。
        /// </summary>
        public string PropList { get; set; }

        /// <summary>
        /// 绑定属性,根据类目确定绑定属性是否是必须。
        /// </summary>
        public string BindPropList { get; set; }

        /// <summary>
        /// 销售属性。
        /// </summary>
        public string SalePropList { get; set; }

        /// <summary>
        /// 用户自定义属性，1636953:DDFAFAEED。
        /// </summary>
        public string CustomPropList { get; set; }

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
        /// 产品主图，要先上传图片后再提交测试，否则产品图片不会被提交。
        /// </summary>
        public string PicPath { get; set; }

        public ProductAddRequest(string sessionKey)
        {
            if (string.IsNullOrEmpty(sessionKey))
            {
                throw new ArgumentNullException("sessionKey");
            }
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

            parameters.Add("cid", this.CategoryId);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("props", this.PropList);
            parameters.Add("binds", this.BindPropList);
            parameters.Add("sale_props", this.SalePropList);
            parameters.Add("customer_props", this.CustomPropList);
            parameters.Add("name", this.Name);
            parameters.Add("price", this.Price);
            parameters.Add("desc", this.Description);

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

            parameters.Add("image", this.PicPath);

            return parameters;
        }

        #endregion
    }
}
