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
        /// 需返回的字段列表.可选值:TaobaokeShop淘宝客商品结构体中的所有字段;字段之间用,分隔。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 店铺id串.最大输入10个.格式如:value1,value2,value3。
        /// </summary>
        public string Sids { get; set; }

        /// <summary>
        /// 推广者的淘宝会员昵称。
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 自定义输入串.格式:英文和数字组成;长度不能大于12个字符,区分不同的推广渠道,如:bbs,表示bbs为推广渠道;blog,表示blog为推广渠道。
        /// </summary>
        public string OuterCode { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.shops.convert";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("sids", this.Sids);
            parameters.Add("nick", this.Nick);
            parameters.Add("outerCode", this.OuterCode);

            return parameters;
        }

        #endregion
    }
}
