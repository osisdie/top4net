using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// TOP XML对象响应通用解释器。
    /// </summary>
    public class ObjectXmlParser<T> : ITopParser<T>
    {
        private static Hashtable parsers = Hashtable.Synchronized(new Hashtable());

        private ParseData parseData;

        public ObjectXmlParser(ParseData parseData)
        {
            this.parseData = parseData;
        }

        #region ITopParser<T> Members

        public T Parse(string body)
        {
            XmlSerializer serializer = parsers[parseData.Api] as XmlSerializer;
            if (serializer == null)
            {
                XmlAttributes rootAttrs = new XmlAttributes();
                rootAttrs.XmlRoot = new XmlRootAttribute(TopUtils.GetRootElement(parseData.Api));

                XmlAttributes objAttrs = new XmlAttributes();
                objAttrs.XmlElements.Add(new XmlElementAttribute(parseData.ItemName, typeof(T)));

                XmlAttributeOverrides attrOvrs = new XmlAttributeOverrides();
                attrOvrs.Add(typeof(PageList<T>), rootAttrs);
                attrOvrs.Add(typeof(PageList<T>), "Content", objAttrs);

                serializer = new XmlSerializer(typeof(PageList<T>), attrOvrs);
                // double check contain
                if (!parsers.ContainsKey(parseData.Api))
                {
                    parsers.Add(parseData.Api, serializer);
                }
            }

            object obj = serializer.Deserialize(new StringReader(body));
            return (obj as PageList<T>).FirstResult;
        }

        #endregion
    }
}
