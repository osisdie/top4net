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
        public static bool VerifyTopResponse(string callbackUrl, string appSecret)
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

            byte[] bytes = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(result.ToString()));
            string sign = Convert.ToBase64String(bytes);

            return queryDict.ContainsKey("top_sign") && Uri.EscapeDataString(sign) == queryDict["top_sign"];
        }

        /// <summary>
        /// 验证回调地址的签名是否合法。
        /// </summary>
        /// <param name="topParams">TOP私有参数（未经Base64解密后的）</param>
        /// <param name="topSession">TOP私有会话码</param>
        /// <param name="topSign">TOP回调签名（经过URL反编码的）</param>
        /// <param name="appKey">应用公钥</param>
        /// <param name="appSecret">应用密钥</param>
        /// <returns>验证成功返回True，否则返回False</returns>
        public static bool VerifyTopResponse(string topParams, string topSession, string topSign, string appKey, string appSecret)
        {
            StringBuilder result = new StringBuilder();
            result.Append(appKey).Append(topParams).Append(topSession).Append(appSecret);
            byte[] bytes = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(result.ToString()));
            return Convert.ToBase64String(bytes) == topSign;
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

        /// <summary>
        /// 获取文件的真实后缀名。目前只支持JPG, GIF, PNG, BMP四种图片文件。
        /// </summary>
        /// <param name="bytes">文件字节流</param>
        /// <returns>JPG, GIF, PNG or null</returns>
        public static string GetFileSuffix(byte[] bytes)
        {
            if (bytes == null || bytes.Length < 10)
            {
                return null;
            }

            if (bytes[0] == 'G' && bytes[1] == 'I' && bytes[2] == 'F')
            {
                return "GIF";
            }
            else if (bytes[1] == 'P' && bytes[2] == 'N' && bytes[3] == 'G')
            {
                return "PNG";
            }
            else if (bytes[6] == 'J' && bytes[7] == 'F' && bytes[8] == 'I' && bytes[9] == 'F')
            {
                return "JPG";
            }
            else if (bytes[0] == 'B' && bytes[1] == 'M')
            {
                return "BMP";
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取文件的真实媒体类型。目前只支持JPG, GIF, PNG, BMP四种图片文件。
        /// </summary>
        /// <param name="bytes">文件字节流</param>
        /// <returns>媒体类型</returns>
        public static string GetMimeType(byte[] bytes)
        {
            string suffix = GetFileSuffix(bytes);
            string mimeType;

            switch (suffix)
            {
                case "JPG": mimeType = "image/jpeg"; break;
                case "GIF": mimeType = "image/gif"; break;
                case "PNG": mimeType = "image/png"; break;
                case "BMP": mimeType = "image/bmp"; break;
                default: mimeType = "application/octet-stream"; break;
            }

            return mimeType;
        }

        /// <summary>
        /// 根据文件后缀名获取文件的媒体类型。
        /// </summary>
        /// <param name="fileName">带后缀的文件名或文件全名</param>
        /// <returns>媒体类型</returns>
        public static string GetMimeType(string fileName)
        {
            string mimeType;
            fileName = fileName.ToLower();

            if (fileName.EndsWith(".bmp"))
            {
                mimeType = "image/bmp";
            }
            else if (fileName.EndsWith(".gif"))
            {
                mimeType = "image/gif";
            }
            else if (fileName.EndsWith(".jpg") || fileName.EndsWith(".jpeg"))
            {
                mimeType = "image/jpeg";
            }
            else if (fileName.EndsWith(".png"))
            {
                mimeType = "image/png";
            }
            else
            {
                mimeType = "application/octet-stream";
            }

            return mimeType;
        }
    }
}
