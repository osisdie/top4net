using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemprops.get.v2
    /// </summary>
    public class ItemPropsGetRequest : ITopRequest
    {
        /// <summary>
        /// 返回的字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 叶子类目编号。
        /// </summary>
        public string LeafCid { get; set; }

        /// <summary>
        /// 属性编号。
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 父属性编号。
        /// </summary>
        public string ParentPid { get; set; }

        /// <summary>
        /// 是否关键属性。
        /// </summary>
        public Nullable<bool> IsKeyProp { get; set; }

        /// <summary>
        /// 是否销售属性。
        /// </summary>
        public Nullable<bool> IsSaleProp { get; set; }

        /// <summary>
        /// 是否颜色属性。
        /// </summary>
        public Nullable<bool> IsColorProp { get; set; }

        /// <summary>
        /// 是否枚举属性。
        /// </summary>
        public Nullable<bool> IsEnumProp { get; set; }

        /// <summary>
        /// 是否是卖家可以自行输入的属性。
        /// </summary>
        public Nullable<bool> IsInputProp { get; set; }

        /// <summary>
        /// 是否商品属性。
        /// </summary>
        public Nullable<bool> IsItemProp { get; set; }

        /// <summary>
        /// 增量时间戳。
        /// </summary>
        public Nullable<DateTime> DateTime { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemprops.get.v2";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("fields", this.Fields);
            parameters.Add("cid", this.LeafCid);
            parameters.Add("pid", this.Pid);
            parameters.Add("parent_pid", this.ParentPid);
            parameters.Add("is_key_prop", this.IsKeyProp);
            parameters.Add("is_sale_prop", this.IsSaleProp);
            parameters.Add("is_color_prop", this.IsColorProp);
            parameters.Add("is_enum_prop", this.IsEnumProp);
            parameters.Add("is_input_prop", this.IsInputProp);
            parameters.Add("is_item_prop", this.IsItemProp);
            parameters.Add("datetime", this.DateTime);

            return parameters;
        }

        #endregion
    }
}
