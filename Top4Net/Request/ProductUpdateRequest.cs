using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// 更新产品信息。
    /// </summary>
    public class ProductUpdateRequest : ITopRequest
    {
        #region ITopRequest Members

        public string GetApiName()
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, string> GetParameters()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
