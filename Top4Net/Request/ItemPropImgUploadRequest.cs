using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.propimg.upload
    /// </summary>
    public class ItemPropimgUploadRequest : ITopUploadRequest
    {
        public Nullable<long> Id { get; set; }
        public string Iid { get; set; }
        public FileItem Image { get; set; }
        public Nullable<long> NumIid { get; set; }
        public Nullable<int> Position { get; set; }
        public string Properties { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.propimg.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("iid", this.Iid);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("position", this.Position);
            parameters.Add("properties", this.Properties);
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
