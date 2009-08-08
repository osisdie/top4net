using System;
using System.Xml;
using System.Collections.Generic;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 淘宝客推广地址的XML响应解释器。
    /// </summary>
    public class TaobaokeListUrlXmlParser : ITopParser<string>
    {
        #region ITopParser<string> Members

        public string Parse(string body)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(body);
            XmlNode listUrl = xmlDoc.SelectSingleNode("/rsp/taobaokeItem/list_url_by_q");
            return listUrl == null ? null : listUrl.InnerText;
        }

        #endregion
    }
}
