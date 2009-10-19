using System;
using System.Collections.Generic;

using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.app.subapp.apply
    /// </summary>
    public class SubappApplyRequest : ITopRequest
    {
        /// <summary>
        /// 父应用的编号。
        /// </summary>
        public string ParentAppKey { get; set; }

        /// <summary>
        /// 子应用的标题。
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 子应用回调地址。
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 子应用通知地址。
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 申请子应用需要用户开通的服务码。
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// 子应用图标。
        /// </summary>
        public FileItem Logo { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.app.subapp.apply";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("parent_app_key", this.ParentAppKey);
            parameters.Add("title", this.Title);
            parameters.Add("callback_url", this.CallbackUrl);
            parameters.Add("notify_url", this.NotifyUrl);
            parameters.Add("service_code", this.ServiceCode);
            parameters.Add("logo", this.Logo);
            return parameters;
        }

        #endregion
    }
}
