using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.sku.delete
    /// </summary>
    public class ItemSkuDeleteRequest : ITopRequest
    {
        public string Iid { get; set; }
        public Nullable<int> ItemNum { get; set; }
        public string ItemPrice { get; set; }
        public string Lang { get; set; }
        public Nullable<long> NumIid { get; set; }
        public string Properties { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.sku.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("iid", this.Iid);
            parameters.Add("item_num", this.ItemNum);
            parameters.Add("item_price", this.ItemPrice);
            parameters.Add("lang", this.Lang);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("properties", this.Properties);
            return parameters;
        }

        #endregion
    }
}
