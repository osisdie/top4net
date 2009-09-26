using System;
using System.IO;
using System.Collections.Generic;

using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.refund.message.add
    /// </summary>
    public class RefundMessageAddRequest : ITopUploadRequest
    {
        /// <summary>
        /// 退款编号。
        /// </summary>
        public string Rid { get; set; }

        /// <summary>
        /// 退款留言内容。
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 用户昵称。
        /// </summary>
        public string OwnerNick { get; set; }

        /// <summary>
        /// 留言图片凭证。
        /// </summary>
        public FileItem Image { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.refund.message.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("refund_id", this.Rid);
            parameters.Add("owner_nick", this.OwnerNick);
            parameters.Add("content", this.Content);

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
