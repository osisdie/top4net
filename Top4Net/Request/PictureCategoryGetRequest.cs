using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.category.get
    /// </summary>
    public class PictureCategoryGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 图片分类编号。
        /// </summary>
        public string PicCategoryId { get; set; }

        /// <summary>
        /// 图片分类名。
        /// </summary>
        public string PicCategoryName { get; set; }

        /// <summary>
        /// 分类类型。
        /// </summary>
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.category.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("fields", this.Fields);
            parameters.Add("picture_category_id", this.PicCategoryId);
            parameters.Add("picture_category_name", this.PicCategoryName);
            parameters.Add("type", this.Type);

            return parameters;
        }

        #endregion
    }
}
