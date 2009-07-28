using System;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 基础领域对象。
    /// </summary>
    [Serializable]
    public abstract class BaseObject
    {
        /// <summary>
        /// TOP默认时间格式。
        /// </summary>
        public const string DATE_TIME_FORMAT = "yyyy-MM-dd HH:mm:ss";
    }
}
