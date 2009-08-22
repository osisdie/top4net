using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.get
    /// </summary>
    public class PictureGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 图片编号。
        /// </summary>
        public string PicId { get; set; }

        /// <summary>
        /// 图片分类编号。
        /// </summary>
        public string PicCategoryId { get; set; }

        /// <summary>
        /// 是否删除。
        /// </summary>
        public string Deleted { get; set; }

        /// <summary>
        /// 图片编辑时间。
        /// </summary>
        public string Modified { get; set; }

        /// <summary>
        /// 图片标题。
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 图片查询结果排序。
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public Nullable<int> PageNo { get; set; }

        /// <summary>
        /// 每页条数。
        /// </summary>
        public Nullable<int> PageSize { get; set; }

        /// <summary>
        /// 查询上传开始时间点。
        /// </summary>
        public Nullable<DateTime> StartDate { get; set; }

        /// <summary>
        /// 查询上传结束时间点。
        /// </summary>
        public Nullable<DateTime> EndDate { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("fields", this.Fields);
            parameters.Add("picture_id", this.PicId);
            parameters.Add("picture_category_id", this.PicCategoryId);
            parameters.Add("deleted", this.Deleted);
            parameters.Add("modified_time", this.Modified);
            parameters.Add("title", this.Title);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_date", this.StartDate);
            parameters.Add("end_date", this.EndDate);

            return parameters;
        }

        #endregion
    }
}
