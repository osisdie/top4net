using System.IO;
using System.Xml.Serialization;
using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// TOP XML列表对象响应通用解释器。
    /// </summary>
    public class ListXmlParser<T> : ITopParser<PageList<T>>
    {
        private ParseData parseData;

        public ListXmlParser(ParseData parseData)
        {
            this.parseData = parseData;
        }

        #region ITopParser<PageList<T>> Members

        public PageList<T> Parse(string body)
        {
            XmlAttributes rootAttrs = new XmlAttributes();
            rootAttrs.XmlRoot = new XmlRootAttribute(TopUtils.GetRootElement(parseData.Api));

            XmlAttributes listAttrs = new XmlAttributes();
            listAttrs.XmlArray = new XmlArrayAttribute(parseData.ListName);
            listAttrs.XmlArrayItems.Add(new XmlArrayItemAttribute(parseData.ItemName, typeof(T)));

            XmlAttributeOverrides attrOvrs = new XmlAttributeOverrides();
            attrOvrs.Add(typeof(PageList<T>), rootAttrs);
            attrOvrs.Add(typeof(PageList<T>), "Content", listAttrs);

            XmlSerializer serializer = new XmlSerializer(typeof(PageList<T>), attrOvrs);
            object obj = serializer.Deserialize(new StringReader(body));
            return obj as PageList<T>;
        }

        #endregion
    }
}
