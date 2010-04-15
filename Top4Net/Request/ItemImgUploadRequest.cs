using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.img.upload
    /// </summary>
    public class ItemImgUploadRequest : ITopUploadRequest
    {
        public Nullable<long> Id { get; set; }
        public string Iid { get; set; }
        public FileItem Image { get; set; }
        public Nullable<bool> IsMajor { get; set; }
        public Nullable<long> NumIid { get; set; }
        public Nullable<int> Position { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.img.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("iid", this.Iid);
            parameters.Add("is_major", this.IsMajor);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("position", this.Position);
            return parameters;
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("image", this.Image);
            return parameters;
        }

        #endregion
    }
}
