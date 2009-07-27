using System;
using System.IO;
using System.Net;
using System.Xml;
using System.Text;
using System.Collections.Generic;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Taobao.Top.Api
{
    /// <summary>
    /// 基于REST的TOP客户端。
    /// </summary>
    public class TopRestClient : ITopClient
    {
        public static readonly string APP_KEY = "app_key";
        public static readonly string FORMAT = "format";
        public static readonly string METHOD = "method";
        public static readonly string TIMESTAMP = "timestamp";
        public static readonly string VERSION = "v";
        public static readonly string SIGN = "sign";

        public static readonly string FORMAT_JSON = "json";
        public static readonly string FORMAT_XML = "xml";

        private string serverUrl;
        private string appKey;
        private string appSecret;
        private long partnerId = 300L;
        private string format = FORMAT_JSON;

        public TopRestClient(string serverUrl, string appKey, string appSecret)
        {
            this.appKey = appKey;
            this.appSecret = appSecret;
            this.serverUrl = serverUrl;
        }

        public TopRestClient(string serverUrl, string appKey, string appSecret, long partnerId)
            : this(serverUrl, appKey, appSecret)
        {
            this.partnerId = partnerId;
        }

        public TopRestClient(string serverUrl, string appKey, string appSecret, string format)
            : this(serverUrl, appKey, appSecret)
        {
            this.format = format;
        }

        public TopRestClient(string serverUrl, string appKey, string appSecret, long partnerId, string format)
            : this(serverUrl, appKey, appSecret, partnerId)
        {
            this.format = format;
        }

        public T Execute<T>(ITopRequest request, ITopParser<T> parser)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(this.serverUrl);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            // 封装请求参数
            UTF8Encoding encoder = new UTF8Encoding();
            byte[] postData = encoder.GetBytes(BuildPostData(request.GetApiName(), request.GetParameters()));
            Stream reqStream = req.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();

            // 以字符流的方向读取HTTP响应
            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            Stream rspStream = rsp.GetResponseStream();
            StreamReader reader = new StreamReader(rspStream);
            StringBuilder result = new StringBuilder();

            // 每次读取不大于256个字符，并写入字符串
            char[] buffer = new char[256];
            int count = reader.Read(buffer, 0, 256);
            while (count > 0)
            {
                result.Append(buffer, 0, count);
                count = reader.Read(buffer, 0, 256);
            }

            // 释放资源
            reader.Close();
            rspStream.Close();
            rsp.Close();

            string response = result.ToString();
            TryParseException(response);
            return parser.Parse(response);
        }

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="apiName">TOP API名称</param>
        /// <param name="parameters">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        private string BuildPostData(string apiName, Dictionary<string, string> parameters)
        {
            StringBuilder postData = new StringBuilder();
            AppendPostData(postData, VERSION, "1.0", false);
            AppendPostData(postData, APP_KEY, appKey);
            AppendPostData(postData, FORMAT, format);
            AppendPostData(postData, METHOD, apiName);
            AppendPostData(postData, TIMESTAMP, DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss"));

            Dictionary<string, string>.Enumerator den = parameters.GetEnumerator();
            while (den.MoveNext())
            {
                AppendPostData(postData, den.Current.Key, den.Current.Value);
            }

            AppendPostData(postData, SIGN, Guid.NewGuid().ToString());

            return postData.ToString();
        }

        /// <summary>
        /// 附加请求参数，并在参数前面添加&符号。
        /// </summary>
        /// <param name="postData">参数串</param>
        /// <param name="name">参数名</param>
        /// <param name="value">参数值</param>
        private void AppendPostData(StringBuilder postData, string name, string value)
        {
            AppendPostData(postData, name, value, true);
        }

        /// <summary>
        /// 附加请求参数。
        /// </summary>
        /// <param name="postData">参数串</param>
        /// <param name="name">参数名</param>
        /// <param name="value">参数值</param>
        /// <param name="hasAnd">是否在参数前添加&符号</param>
        private void AppendPostData(StringBuilder postData, string name, string value, bool hasAnd)
        {
            // 忽略参数名或参数值为空的参数
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(value))
            {
                if (hasAnd)
                {
                    postData.Append("&");
                }
                postData.Append(name);
                postData.Append("=");
                postData.Append(Uri.EscapeUriString(value));
            }
        }

        /// <summary>
        /// 尝试把错误响应转化为异常。
        /// </summary>
        /// <param name="response">API响应</param>
        private void TryParseException(string response)
        {
            if (FORMAT_JSON.Equals(format))
            {
                // 为了避免二次解释JSON，采用StartsWith判断
                if (response.StartsWith("{\"error_rsp\":"))
                {
                    JObject json = JObject.Parse(response);
                    JToken token;
                    if (json.TryGetValue("error_rsp", out token))
                    {
                        if (token == null)
                        {
                            throw new TopException("Unknown exception!");
                        }
                        else
                        {
                            throw new TopException((int)token["code"], (string)token["msg"]);
                        }
                    }
                }
            }
            else if (FORMAT_XML.Equals(format))
            {
                // 为了避免二次解释XML，采用XPath访问节点
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(response);
                XmlNode errRsp = xmlDoc.SelectSingleNode("/error_rsp");
                if (errRsp != null)
                {
                    XmlNode errCodeNode = xmlDoc.SelectSingleNode("/error_rsp/code");
                    XmlNode errMsgNode = xmlDoc.SelectSingleNode("/error_rsp/msg");

                    if (errCodeNode == null || errMsgNode == null)
                    {
                        throw new TopException("Unknown exception!");
                    }
                    else
                    {
                        throw new TopException(int.Parse(errCodeNode.InnerText), errMsgNode.InnerText);
                    }
                }
            }
            else
            {
                // 暂时只支持JSON和XML两种返回格式
                throw new TopException("Unsupported response format!");
            }
        }
    }
}
