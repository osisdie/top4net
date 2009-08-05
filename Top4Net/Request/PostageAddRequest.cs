using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.postage.add
    /// </summary>
    public class PostageAddRequest : ITopPrivateRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 邮费模板名称。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 邮费模板备注。
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 平邮费用。
        /// </summary>
        public string PostPrice { get; set; }

        /// <summary>
        /// 平邮加件费用   。
        /// </summary>
        public string PostIncrease { get; set; }

        /// <summary>
        /// 快递费用。
        /// </summary>
        public string ExpressPrice { get; set; }

        /// <summary>
        /// 快递加件费用。
        /// </summary>
        public string ExpressIncrease { get; set; }

        /// <summary>
        /// EMS费用。
        /// </summary>
        public string EmsPrice { get; set; }

        /// <summary>
        /// EMS加件费用。
        /// </summary>
        public string EmsIncrease { get; set; }

        /// <summary>
        /// 运费方式(目前提供):平邮 (post),快递公司(express), EMS (ems)数量串: 例 (post;express;ems……)，用 “;”区分。
        /// </summary>
        public string PostageModeType { get; set; }

        /// <summary>
        /// 目的地值,涉及的地区,数值用逗号连接数量串: 例 (10;20;30,10) .填写时要注意对照地区代码值,如果填入错误地区代码, 将会出现错误信息。
        /// </summary>
        public string PostageModeDest { get; set; }

        /// <summary>
        /// 运费方式单价 数量串: 例 (11.2;14;6……)。
        /// </summary>
        public string PostageModePrice { get; set; }

        /// <summary>
        /// 运费方式加件费用 数量串: 例 (1.5;2……)。
        /// </summary>
        public string PostageModeIncrease { get; set; }

        /// <summary>
        /// 产品主图文件绝对地址。
        /// </summary>
        public string PrimaryPicPath { get; set; }

        public PostageAddRequest(string sessionKey)
        {
            if (string.IsNullOrEmpty(sessionKey))
            {
                throw new ArgumentNullException("sessionKey");
            }
            this.sessionKey = sessionKey;
        }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.postage.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("name", this.Name);
            parameters.Add("memo", this.Memo);
            parameters.Add("post_price", this.PostPrice);
            parameters.Add("post_increase", this.PostIncrease);
            parameters.Add("express_price", this.ExpressPrice);
            parameters.Add("express_increase", this.ExpressIncrease);
            parameters.Add("ems_price", this.EmsPrice);
            parameters.Add("ems_increase", this.EmsIncrease);
            parameters.Add("postage_mode.type", this.PostageModeType);
            parameters.Add("postage_mode.dest", this.PostageModeDest);
            parameters.Add("postage_mode.price", this.PostageModePrice);
            parameters.Add("postage_mode.increase", this.PostageModeIncrease);

            return parameters;
        }

        #endregion

        #region ITopPrivateRequest Members

        public string GetSessionKey()
        {
            return this.sessionKey;
        }

        #endregion
    }
}
