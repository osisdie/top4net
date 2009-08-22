using System;
using System.Collections.Generic;

namespace Taobao.Top.Api
{
    /// <summary>
    /// 符合TOP习惯的纯字符串字典结构。
    /// </summary>
    public class TopDictionary : Dictionary<string, string>
    {
        /// <summary>
        /// 添加一个新的键值对。空键或者空值的键值对将会被忽略。
        /// </summary>
        /// <param name="key">键名称</param>
        /// <param name="value">键对应的值，目前支持：string, DateTime, int, long, bool类型</param>
        public void Add(string key, object value)
        {
            string strValue;

            if (value == null)
            {
                strValue = null;
            }
            else if (value is string)
            {
                strValue = value as string;
            }
            else if (value is Nullable<DateTime>)
            {
                Nullable<DateTime> dateTime = value as Nullable<DateTime>;
                strValue = dateTime.Value.ToString(Constants.DATE_TIME_FORMAT);
            }
            else if (value is Nullable<int>)
            {
                strValue = (value as Nullable<int>).Value.ToString();
            }
            else if (value is Nullable<long>)
            {
                strValue = (value as Nullable<long>).Value.ToString();
            }
            else if (value is Nullable<bool>)
            {
                strValue = (value as Nullable<bool>).Value.ToString().ToLower();
            }
            else
            {
                strValue = value.ToString();
            }

            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(strValue))
            {
                base.Add(key, strValue);
            }
        }
    }
}
