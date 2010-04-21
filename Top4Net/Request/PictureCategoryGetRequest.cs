using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.category.get
    /// </summary>
    public class PictureCategoryGetRequest : ITopRequest
    {
        public Nullable<long> PictureCategoryId { get; set; }
        public string PictureCategoryName { get; set; }
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.category.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("picture_category_id", this.PictureCategoryId);
            parameters.Add("picture_category_name", this.PictureCategoryName);
            parameters.Add("type", this.Type);
            return parameters;
        }

        #endregion
    }
}
