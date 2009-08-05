using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.listurl.get
    /// </summary>
    public class TaobaokeListurlGetRequest : ITopRequest
    {
        /// <summary>
        /// 需返回的字段列表.可选值:TaobaokeItem淘宝客商品结构体中的所有字段;。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 关键词。
        /// </summary>
        public string Query { get; set; }

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
            return "taobao.taobaoke.listurl.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("q", this.Query);
            parameters.Add("nick", this.Nick);
            parameters.Add("outerCode", this.OuterCode);

            return parameters;
        }

        #endregion
    }
}
