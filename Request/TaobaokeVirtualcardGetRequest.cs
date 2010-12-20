using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.virtualcard.get
    /// </summary>
    public class TaobaokeVirtualcardGetRequest : ITopRequest<TaobaokeVirtualcardGetResponse>
    {
        /// <summary>
        /// 电话卡地区
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 电话卡或游戏点卡标记.  电话卡：phoneCard，游戏卡：gameCard
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 电话充值卡类型.  卖家代充：autoship，自动发货：autopost，10分钟代充：10minship
        /// </summary>
        public string CardType { get; set; }

        /// <summary>
        /// 需返回的字段列表.可选值:num_iid,title,nick,pic_url,price,click_url,commission,ommission_rate,commission_num,commission_volume,shop_click_url,seller_credit_score,item_location,volume ;字段之间用","分隔
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 游戏名
        /// </summary>
        public string GameName { get; set; }

        /// <summary>
        /// 淘宝用户昵称，注：指的是淘宝的会员登录名.如果昵称错误,那么客户就收不到佣金.每个淘宝昵称都对应于一个pid，在这里输入要结算佣金的淘宝昵称，当推广的商品成功后，佣金会打入此输入的淘宝昵称的账户。具体的信息可以登入阿里妈妈的网站查看
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 电话卡运营商.  1:移动 2:联通 3:电信
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 自定义输入串.格式:英文和数字组成;长度不能大于12个字符,区分不同的推广渠道,如:bbs,表示bbs为推广渠道;blog,表示blog为推广渠道.
        /// </summary>
        public string OuterCode { get; set; }

        /// <summary>
        /// 结果页数.1~99
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页返回结果数.最大每页40
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 淘客id
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 充值卡面值
        /// </summary>
        public string Price { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.virtualcard.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("area", this.Area);
            parameters.Add("biz_type", this.BizType);
            parameters.Add("card_type", this.CardType);
            parameters.Add("fields", this.Fields);
            parameters.Add("game_name", this.GameName);
            parameters.Add("nick", this.Nick);
            parameters.Add("operator", this.Operator);
            parameters.Add("outer_code", this.OuterCode);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("pid", this.Pid);
            parameters.Add("price", this.Price);
            return parameters;
        }

        #endregion
    }
}
