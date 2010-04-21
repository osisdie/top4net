using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.delete
    /// </summary>
    public class PictureDeleteRequest : ITopRequest
    {
        public string PictureIds { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("picture_ids", this.PictureIds);
            return parameters;
        }

        #endregion
    }
}
