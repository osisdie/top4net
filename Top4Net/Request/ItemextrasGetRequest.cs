using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemextras.get
    /// </summary>
    public class ItemextrasGetRequest : ITopRequest
    {
        public string ApproveStatus { get; set; }
        public string Fields { get; set; }
        public string Nick { get; set; }
        public string OrderBy { get; set; }
        public Nullable<int> PageNo { get; set; }
        public Nullable<int> PageSize { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemextras.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("approve_status", this.ApproveStatus);
            parameters.Add("fields", this.Fields);
            parameters.Add("nick", this.Nick);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            return parameters;
        }

        #endregion
    }
}
