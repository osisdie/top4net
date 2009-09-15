using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Taobao.Top.Api.Util
{
    /// <summary>
    /// 系统工具类。
    /// </summary>
    public abstract class SysUtils
    {
        /// <summary>
        /// 给TOP请求签名。
        /// </summary>
        /// <param name="parameters">所有字符型的TOP请求参数</param>
        /// <param name="secret">签名密钥</param>
        /// <returns>签名</returns>
        public static string SignTopRequest(IDictionary<string, string> parameters, string secret)
        {
            // 第一步：把字典按Key的字母顺序排序
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters);
            IEnumerator<KeyValuePair<string, string>> dem = sortedParams.GetEnumerator();

            // 第二步：把所有参数名和参数值串在一起
            StringBuilder query = new StringBuilder(secret);
            while (dem.MoveNext())
            {
                string key = dem.Current.Key;
                string value = dem.Current.Value;
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                {
                    query.Append(key).Append(value);
                }
            }

            // 第三步：使用MD5加密
            MD5 md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(query.ToString()));

            // 第四步：把二进制转化为大写的十六进制
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                string hex = bytes[i].ToString("X");
                if (hex.Length == 1)
                {
                    result.Append("0");
                }
                result.Append(hex);
            }

            return result.ToString();
        }

        /// <summary>
        /// 验证回调地址的签名是否合法。
        /// </summary>
        /// <param name="callbackUrl">回调地址</param>
        /// <param name="appSecret">应用密钥</param>
        /// <returns>验证成功返回True，否则返回False</returns>
        public static bool SignTopResponse(string callbackUrl, string appSecret)
        {
            Uri uri = new Uri(callbackUrl);

            string query = uri.Query;
            if (string.IsNullOrEmpty(query)) // 没有回调参数
            {
                return false;
            }

            query = query.Trim(new char[] { '?', ' ' });
            if (query.Length == 0) // 没有回调参数
            {
                return false;
            }

            IDictionary<string, string> queryDict = new Dictionary<string, string>();
            string[] queryParams = query.Split(new char[] { '&' });

            if (queryParams != null && queryParams.Length > 0)
            {
                foreach (string queryParam in queryParams)
                {
                    string[] oneParam = queryParam.Split(new char[] { '=' });
                    if (oneParam.Length >= 2)
                    {
                        queryDict.Add(oneParam[0], oneParam[1]);
                    }
                }
            }

            StringBuilder result = new StringBuilder();
            if (queryDict.ContainsKey("top_appkey")) result.Append(queryDict["top_appkey"]);
            if (queryDict.ContainsKey("top_parameters")) result.Append(queryDict["top_parameters"]);
            if (queryDict.ContainsKey("top_session")) result.Append(queryDict["top_session"]);
            result.Append(appSecret);

            MD5 md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(result.ToString()));
            string sign = Convert.ToBase64String(bytes);

            return queryDict.ContainsKey("top_sign") && Uri.EscapeDataString(sign) == queryDict["top_sign"];
        }

        /// <summary>
        /// 清除字典中值为空的项。
        /// </summary>
        /// <param name="dict">待清除的字典</param>
        /// <returns>清除后的字典</returns>
        public static IDictionary<string, string> CleanupDictionary(IDictionary<string, string> dict)
        {
            IDictionary<string, string> newDict = new Dictionary<string, string>();
            IEnumerator<KeyValuePair<string, string>> dem = dict.GetEnumerator();

            while (dem.MoveNext())
            {
                string name = dem.Current.Key;
                string value = dem.Current.Value;
                if (!string.IsNullOrEmpty(value))
                {
                    newDict.Add(name, value);
                }
            }

            return newDict;
        }
    }
}
