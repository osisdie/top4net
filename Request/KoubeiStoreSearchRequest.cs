using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.koubei.store.search
    /// </summary>
    public class KoubeiStoreSearchRequest : ITopRequest<KoubeiStoreSearchResponse>
    {
        /// <summary>
        /// 根据一级类目Id查找店铺，比如餐饮美食
        /// </summary>
        public Nullable<long> CateId { get; set; }

        /// <summary>
        /// 城市id
        /// </summary>
        public Nullable<long> CityId { get; set; }

        /// <summary>
        /// 页码，显示第page页的店铺。
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 返回的店铺数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 平均消费,传入价格区间，整数用波浪线分隔
        /// </summary>
        public string PerPrice { get; set; }

        /// <summary>
        /// 关键词搜索时使用
        /// </summary>
        public string Q { get; set; }

        /// <summary>
        /// 需要定位搜索店铺时使用，以指定的xy为中心，（+-）range米范围内店铺。
        /// </summary>
        public Nullable<long> Range { get; set; }

        /// <summary>
        /// 根据店铺名搜索时使用，返回店铺名中带有storeName的店铺
        /// </summary>
        public string StoreName { get; set; }

        /// <summary>
        /// 根据二级类目Id查找店铺，比如中餐馆
        /// </summary>
        public Nullable<long> SubcateId { get; set; }

        /// <summary>
        /// 需要定位搜索店铺时使用，经度,已经将经度的分秒转换成度的小数部分，最好精确到小数点后5位
        /// </summary>
        public string X { get; set; }

        /// <summary>
        /// 需要定位搜索店铺时使用，纬度,已经将纬度的分秒转换成度的小数部分，最好精确到小数点后5位
        /// </summary>
        public string Y { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.koubei.store.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cate_id", this.CateId);
            parameters.Add("city_id", this.CityId);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("per_price", this.PerPrice);
            parameters.Add("q", this.Q);
            parameters.Add("range", this.Range);
            parameters.Add("store_name", this.StoreName);
            parameters.Add("subcate_id", this.SubcateId);
            parameters.Add("x", this.X);
            parameters.Add("y", this.Y);
            return parameters;
        }

        #endregion
    }
}
