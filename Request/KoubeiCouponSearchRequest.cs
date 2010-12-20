using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.koubei.coupon.search
    /// </summary>
    public class KoubeiCouponSearchRequest : ITopRequest<KoubeiCouponSearchResponse>
    {
        /// <summary>
        /// 口碑城市代码，可参见口碑全国各城市的对照表
        /// </summary>
        public Nullable<long> CityId { get; set; }

        /// <summary>
        /// 搜索用的排序字段，暂时只支持publish_time,offer_hits.升降序规则是排序字段加英文逗号加DESC或ASC  比如：offer_hits,DESC
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 页码.传入值为1代表第一页,传入值为2代表第二页,依此类推.默认返回的数据是从第一页开始
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页数量默认10条，最大1000条
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 搜索商圈的范围
        /// </summary>
        public Nullable<long> PeriRange { get; set; }

        /// <summary>
        /// 搜索用的关键字
        /// </summary>
        public string Q { get; set; }

        /// <summary>
        /// 搜索用是否支持短信下载,如果使用该参数即使赋值空在内部处理时也会以false值进行查询
        /// </summary>
        public Nullable<bool> SmsDown { get; set; }

        /// <summary>
        /// 搜索用店的id
        /// </summary>
        public string StoreId { get; set; }

        /// <summary>
        /// 优惠券子类目，比如10123,10124,10125,10126,10127
        /// </summary>
        public Nullable<long> SubCate { get; set; }

        /// <summary>
        /// 经度,已经将经度的分秒转换成度的小数部分,最好精确到小数点后5位
        /// </summary>
        public string X { get; set; }

        /// <summary>
        /// 纬度，已经将纬度的分秒转换成度的小数部分，最好精确到小数点后5位
        /// </summary>
        public string Y { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.koubei.coupon.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("city_id", this.CityId);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("peri_range", this.PeriRange);
            parameters.Add("q", this.Q);
            parameters.Add("sms_down", this.SmsDown);
            parameters.Add("store_id", this.StoreId);
            parameters.Add("sub_cate", this.SubCate);
            parameters.Add("x", this.X);
            parameters.Add("y", this.Y);
            return parameters;
        }

        #endregion
    }
}
