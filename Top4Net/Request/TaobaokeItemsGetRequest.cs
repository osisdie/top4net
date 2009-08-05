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
        /// 需要返回的字段: iid,title,nick,pic_url,price,click_url。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 输入格式: "mm_会员id_网站id_广告位id" 注意,如果会员id错误，那么客户就收不到佣金. 网站id和广告位id可以为0。
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 商品标题中包含的关键字 注意：查询时keyword,cid至少选择其中一个参数。
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 商品所属分类id。
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// 起始价格 传入价格参数时，需注意起始价格和最高价格必须一起传入,并且 strat_price <= end_price 。
        /// </summary>
        public string StratPrice { get; set; }

        /// <summary>
        /// 最高价格。
        /// </summary>
        public string EndPrice { get; set; }

        /// <summary>
        /// 是否自动发货，true或false。
        /// </summary>
        public string AuotSend { get; set; }

        /// <summary>
        /// 商品所在地。
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 卖家信用。
        /// </summary>
        public string Credit { get; set; }

        /// <summary>
        /// 默认排序 : default 价格从高到低: price_desc 价格从低到高: price_asc 信用等级从高到低: credit_desc。
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// 是否查询消保卖家，true或false。
        /// </summary>
        public string IsGuarantee { get; set; }

        /// <summary>
        /// 结果页数,1~99。
        /// </summary>
        public string PageNo { get; set; }

        /// <summary>
        /// 每页返回结果数,40。
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

            parameters.Add("fields", this.Fields);
            parameters.Add("pid", this.Pid);
            parameters.Add("keyword", this.Keyword);
            parameters.Add("cid", this.CategoryId);
            parameters.Add("strat_price", this.StratPrice);
            parameters.Add("end_price", this.EndPrice);
            parameters.Add("auot_send", this.AuotSend);
            parameters.Add("area", this.Area);
            parameters.Add("credit", this.Credit);
            parameters.Add("sort", this.Sort);
            parameters.Add("is_guarantee", this.IsGuarantee);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);

            return parameters;
        }

        #endregion
    }
}
