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
        /// 返回的字段(该接口不返回属性值)。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 叶子类目ID，如果只传cid，则只返回一级属性。
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 属性id (取类目属性时，传pid，不用同时传PID和parent_pid)。
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 父属性ID。
        /// </summary>
        public string ParentPid { get; set; }

        /// <summary>
        /// 是否关键属性。
        /// </summary>
        public string IsKeyProp { get; set; }

        /// <summary>
        /// 是否销售属性。
        /// </summary>
        public string IsSaleProp { get; set; }

        /// <summary>
        /// 是否颜色属性(删除的属性不会匹配和返回这个条件)。
        /// </summary>
        public string IsColorProp { get; set; }

        /// <summary>
        /// 是否枚举属性(删除的属性不会匹配和返回这个条件)。
        /// </summary>
        public string IsEnumProp { get; set; }

        /// <summary>
        /// 是否是卖家可以自行输入的属性(删除的属性不会匹配和返回这个条件)。
        /// </summary>
        public string IsInputProp { get; set; }

        /// <summary>
        /// 是否商品属性. 这个属性只能放于发布商品时使用。
        /// </summary>
        public string IsItemProp { get; set; }

        /// <summary>
        /// 增量时间戳，如果传1970-1-1 00:00:00，则取所有的属性和子属性ID(如果传了pid会忽略datetime)。
        /// </summary>
        public string Datetime { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemprops.get.v2";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("cid", this.Cid);
            parameters.Add("pid", this.Pid);
            parameters.Add("parent_pid", this.ParentPid);
            parameters.Add("is_key_prop", this.IsKeyProp);
            parameters.Add("is_sale_prop", this.IsSaleProp);
            parameters.Add("is_color_prop", this.IsColorProp);
            parameters.Add("is_enum_prop", this.IsEnumProp);
            parameters.Add("is_input_prop", this.IsInputProp);
            parameters.Add("is_item_prop", this.IsItemProp);
            parameters.Add("datetime", this.Datetime);

            return parameters;
        }

        #endregion
    }
}
