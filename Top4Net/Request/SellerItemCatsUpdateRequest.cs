using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sellercats.list.update
    /// </summary>
    public class SellerItemCatsUpdateRequest : ITopRequest
    {
        /// <summary>
        /// 卖家自定义类目名称(name、pict_url、sort_order、promotion_info至少必须传一个)。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 卖家自定义类目id。
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 链接图片地址。
        /// </summary>
        public string PicUrl { get; set; }

        /// <summary>
        /// 该类目在页面上的排序位置。
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// 自定义类目的父类目ID,默认为0。
        /// </summary>
        public string ParentCid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sellercats.list.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("name", this.Name);
            parameters.Add("cid", this.Cid);
            parameters.Add("pict_url", this.PicUrl);
            parameters.Add("sort_order", this.SortOrder);
            parameters.Add("parent_cid", this.ParentCid);

            return parameters;
        }

        #endregion
    }
}
