using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.shipping.address.add
    /// </summary>
    public class ShippingAddressAddRequest : ITopRequest
    {
        public Nullable<bool> IsDefault { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverCity { get; set; }
        public string ReceiverDistrict { get; set; }
        public string ReceiverMobile { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string ReceiverState { get; set; }
        public string ReceiverZip { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.shipping.address.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("is_default", this.IsDefault);
            parameters.Add("receiver_address", this.ReceiverAddress);
            parameters.Add("receiver_city", this.ReceiverCity);
            parameters.Add("receiver_district", this.ReceiverDistrict);
            parameters.Add("receiver_mobile", this.ReceiverMobile);
            parameters.Add("receiver_name", this.ReceiverName);
            parameters.Add("receiver_phone", this.ReceiverPhone);
            parameters.Add("receiver_state", this.ReceiverState);
            parameters.Add("receiver_zip", this.ReceiverZip);
            return parameters;
        }

        #endregion
    }
}
