using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.category.add
    /// </summary>
    public class PictureCategoryAddRequest : ITopRequest
    {
        public string PictureCategoryName { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.category.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("picture_category_name", this.PictureCategoryName);
            return parameters;
        }

        #endregion
    }
}
