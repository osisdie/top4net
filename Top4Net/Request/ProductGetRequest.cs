using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.get
    /// </summary>
    public class ProductGetRequest : ITopRequest
    {
        /// <summary>
        /// Product数据结构字段列表，以半角逗号(,)分隔。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// Product的ID(如果根据product_id查询，就不需要传其他的条件了)。
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 商品类目ID，必须是叶子类目的，如果没有传product_id，那么cid和props必须要传。
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 关键属性列表，格式：pid:vid;pid:vid，比如：诺基亚N73这个PRODUCT的关键属性列表就是：品牌:诺基亚;型号:诺基亚型号，对应的PV值就是10005:10027;10006:29729，该数据可以通过taobao.itemprop.get获取。
        /// </summary>
        public string Props { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("cid", this.Cid);
            parameters.Add("props", this.Props);

            return parameters;
        }

        #endregion
    }
}
