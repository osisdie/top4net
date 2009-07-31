using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Taobao.Top.Api.Util
{
    /// <summary>
    /// 网络工具类。
    /// </summary>
    public abstract class WebUtils
    {
        public static string DoPost(string url, IDictionary<string, string> parameters)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            UTF8Encoding encoding = new UTF8Encoding(true, true);
            byte[] postData = encoding.GetBytes(BuildPostData(parameters));
            Stream reqStream = req.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();

            // 以字符流的方式读取HTTP响应
            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            Stream rspStream = rsp.GetResponseStream();
            StreamReader reader = new StreamReader(rspStream);
            StringBuilder result = new StringBuilder();

            // 每次读取不大于256个字符，并写入字符串
            char[] buffer = new char[256];
            int count = reader.Read(buffer, 0, buffer.Length);
            while (count > 0)
            {
                result.Append(buffer, 0, count);
                count = reader.Read(buffer, 0, buffer.Length);
            }

            // 释放资源
            reader.Close();
            rspStream.Close();
            rsp.Close();

            return result.ToString();
        }

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="parameters">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        private static string BuildPostData(IDictionary<string, string> parameters)
        {
            StringBuilder postData = new StringBuilder();
            bool hasParam = false;

            IEnumerator<KeyValuePair<string, string>> dem = parameters.GetEnumerator();
            while (dem.MoveNext())
            {
                string name = dem.Current.Key;
                string value = dem.Current.Value;
                // 忽略参数名或参数值为空的参数
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(value))
                {
                    if (hasParam)
                    {
                        postData.Append("&");
                    }

                    postData.Append(name);
                    postData.Append("=");
                    postData.Append(Uri.EscapeDataString(value));
                    hasParam = true;
                }
            }

            return postData.ToString();
        }
    }
}
