using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.refund.message.add
    /// </summary>
    public class RefundMessageAddRequest : ITopUploadRequest
    {
        public string Content { get; set; }
        public FileItem Image { get; set; }
        public Nullable<long> RefundId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.refund.message.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("content", this.Content);
            parameters.Add("refund_id", this.RefundId);
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
