using System;
using System.IO;
using System.Net;
using System.Xml;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using Taobao.Top.Api.Util;
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
        public const string APP_KEY = "api_key";
        public const string FORMAT = "format";
        public const string METHOD = "method";
        public const string TIMESTAMP = "timestamp";
        public const string VERSION = "v";
        public const string SIGN = "sign";
        public const string PARTNER_ID = "partner_id";
        public const string SESSION = "session";
        public const string FORMAT_JSON = "json";
        public const string FORMAT_XML = "xml";

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
            // 添加协议级请求参数
            IDictionary<string, string> allParams = new Dictionary<string, string>(request.GetParameters());
            allParams.Add(METHOD, request.GetApiName());
            allParams.Add(VERSION, "1.0");
            allParams.Add(APP_KEY, appKey);
            allParams.Add(FORMAT, format);
            allParams.Add(PARTNER_ID, partnerId + "");
            allParams.Add(TIMESTAMP, DateTime.Now.ToString(Constants.DATE_TIME_FORMAT));
            allParams.Add(SIGN, SystemUtils.SignTopRequest(allParams, appSecret));

            // 为私有API添加访问授权
            if (request is ITopPrivateRequest)
            {
                ITopPrivateRequest privateRequest = request as ITopPrivateRequest;
                allParams.Add(SESSION, privateRequest.GetSessionKey());
            }

            string response = WebUtils.DoPost(this.serverUrl, allParams);
            TryParseException(response);
            return parser.Parse(response);
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
