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
        /// 需返回的字段列表.可选值:TaobaokeItem淘宝客商品结构体中的所有字段
        /// </summary>
        public string Fields { get; set; }
        /// <summary>
        /// 输入格式:"mm_会员id_网站id_广告位id" 网站id和广告位id不输入具体数字时可以输入0 如:"mm_18276335_45872_0",注意:如果会员id错误,那么客户就收不到佣金.
        /// </summary>
        public string Pid { get; set; }
        /// <summary>
        /// 商品标题中包含的关键字. 注意:查询时keyword,cid至少选择其中一个参数
        /// </summary>
        public string Keyword { get; set; }
        /// <summary>
        /// 商品所属分类id
        /// </summary>
        public string Cid { get; set; }
        /// <summary>
        /// 起始价格.传入价格参数时,需注意起始价格和最高价格必须一起传入,并且 start_price <= end_price
        /// </summary>
        public string StartPrice { get; set; }
        /// <summary>
        /// 最高价格
        /// </summary>
        public string EndPrice { get; set; }
        /// <summary>
        /// 是否自动发货
        /// </summary>
        public string AutoSend { get; set; }
        /// <summary>
        /// 商品所在地 例如:杭州
        /// </summary>
        public string Area { get; set; }
        /// <summary>
        /// 卖家信用
        /// </summary>
        public string StartCredit { get; set; }
        /// <summary>
        /// 可选值和start_credit一样.start_credit的值一定要小于end_credit的值.
        /// </summary>
        public string EndCredit { get; set; }
        /// <summary>
        /// 默认排序:default
        /// </summary>
        public string Sort { get; set; }
        /// <summary>
        /// 是否查询消保卖家 true/false
        /// </summary>
        public string IsGuarantee { get; set; }
        /// <summary>
        /// 起始佣金选项
        /// </summary>
        public string StartCommission { get; set; }
        /// <summary>
        /// 最高佣金选项
        /// </summary>
        public string EndCommission { get; set; }
        /// <summary>
        /// 起始佣金比率选项
        /// </summary>
        public string StartCommissionRate { get; set; }
        /// <summary>
        /// 最高佣金比率选项
        /// </summary>
        public string EndCommissionRate { get; set; }
        /// <summary>
        /// 起始累计推广量选项
        /// </summary>
        public string StartCommissionNum { get; set; }
        /// <summary>
        /// 最高累计推广量选项
        /// </summary>
        public string EndCommissionNum { get; set; }
        /// <summary>
        /// 结果页数.1~99
        /// </summary>
        public string PageNo { get; set; }
        /// <summary>
        /// 每页返回结果数.最大每页40
        /// </summary>
        public string PageSize { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.items.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add( "fields", this.Fields );
            parameters.Add( "pid", this.Pid );
            parameters.Add( "keyword", this.Keyword );
            parameters.Add( "cid", this.Cid );
            parameters.Add( "start_price", this.StartPrice );
            parameters.Add( "end_price", this.EndPrice );
            parameters.Add( "auto_send", this.AutoSend );
            parameters.Add( "area", this.Area );
            parameters.Add( "start_credit", this.StartCredit );
            parameters.Add( "end_credit", this.EndCredit );
            parameters.Add( "sort", this.Sort );
            parameters.Add( "is_guarantee", this.IsGuarantee );
            parameters.Add( "start_commission", this.StartCommission );
            parameters.Add( "end_commission", this.EndCommission );
            parameters.Add( "start_commissionRate", this.StartCommissionRate );
            parameters.Add( "end_commissionRate", this.EndCommissionRate );
            parameters.Add( "start_commissionNum", this.StartCommissionNum );
            parameters.Add( "end_commissionNum", this.EndCommissionNum );
            parameters.Add( "page_no", this.PageNo );
            parameters.Add( "page_size", this.PageSize );

            return parameters;
        }

        #endregion
    }
}
