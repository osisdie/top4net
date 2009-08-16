using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.items.get
    /// </summary>
    public class TaobaokeItemsGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 输入格式：mm_会员id_网站id_广告位id。
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 商品标题中包含的关键字。
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 商品所属分类编号。
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 起始价格。
        /// </summary>
        public string StartPrice { get; set; }

        /// <summary>
        /// 最高价格。
        /// </summary>
        public string EndPrice { get; set; }

        /// <summary>
        /// 是否自动发货。
        /// </summary>
        public bool AutoSend { get; set; }

        /// <summary>
        /// 商品所在地。
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 卖家信用。
        /// </summary>
        public string StartCredit { get; set; }

        /// <summary>
        /// 卖家信用。
        /// </summary>
        public string EndCredit { get; set; }

        /// <summary>
        /// 默认排序。
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 是否查询消保卖家。
        /// </summary>
        public bool IsGuarantee { get; set; }

        /// <summary>
        /// 起始佣金选项。
        /// </summary>
        public string StartCommission { get; set; }

        /// <summary>
        /// 最高佣金选项。
        /// </summary>
        public string EndCommission { get; set; }

        /// <summary>
        /// 起始佣金比率选项。
        /// </summary>
        public string StartCommissionRate { get; set; }

        /// <summary>
        /// 最高佣金比率选项。
        /// </summary>
        public string EndCommissionRate { get; set; }

        /// <summary>
        /// 起始累计推广量选项。
        /// </summary>
        public string StartCommissionNum { get; set; }

        /// <summary>
        /// 最高累计推广量选项。
        /// </summary>
        public string EndCommissionNum { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public int PageNo { get; set; }

        /// <summary>
        /// 每页返回结果数。
        /// </summary>
        public int PageSize { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.items.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("pid", this.Pid);
            parameters.Add("keyword", this.Keyword);
            parameters.Add("cid", this.Cid);
            parameters.Add("start_price", this.StartPrice);
            parameters.Add("end_price", this.EndPrice);
            parameters.Add("auto_send", this.AutoSend.ToString());
            parameters.Add("area", this.Area);
            parameters.Add("start_credit", this.StartCredit);
            parameters.Add("end_credit", this.EndCredit);
            parameters.Add("sort", this.OrderBy);
            parameters.Add("is_guarantee", this.IsGuarantee.ToString());
            parameters.Add("start_commission", this.StartCommission);
            parameters.Add("end_commission", this.EndCommission);
            parameters.Add("start_commissionRate", this.StartCommissionRate);
            parameters.Add("end_commissionRate", this.EndCommissionRate);
            parameters.Add("start_commissionNum", this.StartCommissionNum);
            parameters.Add("end_commissionNum", this.EndCommissionNum);
            parameters.Add("page_no", this.PageNo.ToString());
            parameters.Add("page_size", this.PageSize.ToString());

            return parameters;
        }

        #endregion
    }
}
