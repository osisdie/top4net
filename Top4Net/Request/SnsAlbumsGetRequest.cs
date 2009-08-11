using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sns.pictures.getAlbums
    /// </summary>
    public class SnsAlbumsGetRequest : ITopRequest
    {
        /// <summary>
        /// 用户编号。
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// 开始条数。
        /// </summary>
        public int StartRow { get; set; }

        /// <summary>
        /// 查询个数。
        /// </summary>
        public int Count { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sns.pictures.getAlbums";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("uid", this.Uid);
            parameters.Add("start_row", this.StartRow + "");
            parameters.Add("count", this.Count + "");

            return parameters;
        }

        #endregion
    }
}
