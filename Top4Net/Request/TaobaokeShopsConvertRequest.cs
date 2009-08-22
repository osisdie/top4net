using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.shops.convert
    /// </summary>
    public class TaobaokeShopsConvertRequest : ITopRequest
    {
        /// <summary>
        /// 需返回的字段列表。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 店铺编号串。
        /// </summary>
        public string Sids { get; set; }

        /// <summary>
        /// 推广者的淘宝会员昵称。
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 用户自定义输入串。
        /// </summary>
        public string OuterCode { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.shops.convert";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("fields", this.Fields);
            parameters.Add("sids", this.Sids);
            parameters.Add("nick", this.Nick);
            parameters.Add("outer_code", this.OuterCode);

            return parameters;
        }

        #endregion
    }
}
