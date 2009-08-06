using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sns.coins.sum
    /// </summary>
    public class SnsCoinsGetRequest : ITopRequest
    {
        

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sns.coins.sum";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            

            return parameters;
        }

        #endregion
    }
}
