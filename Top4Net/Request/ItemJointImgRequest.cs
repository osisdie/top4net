using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.joint.img
    /// </summary>
    public class ItemJointImgRequest : ITopRequest
    {
        public Nullable<long> Id { get; set; }
        public string Iid { get; set; }
        public Nullable<bool> IsMajor { get; set; }
        public Nullable<long> NumIid { get; set; }
        public string PicPath { get; set; }
        public Nullable<long> Position { get; set; }
        public string Url { get; set; }
        public string V { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.joint.img";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("iid", this.Iid);
            parameters.Add("is_major", this.IsMajor);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("pic_path", this.PicPath);
            parameters.Add("position", this.Position);
            parameters.Add("url", this.Url);
            parameters.Add("v", this.V);
            return parameters;
        }

        #endregion
    }
}
