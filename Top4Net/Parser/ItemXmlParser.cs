using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 商品属性列表的XML响应解释器。
    /// </summary>
    public class ItemPropListXmlParser : ITopParser<ResponseList<ItemProp>>
    {
        #region ITopParser<ResponseList<ItemProp>> Members

        public ResponseList<ItemProp> Parse(string body)
        {
            XmlAttributeOverrides attrs = ResponseList<ItemProp>.GetOverrides("item_prop");
            XmlSerializer serializer = new XmlSerializer(typeof(ResponseList<ItemProp>), attrs);

            object obj = serializer.Deserialize(new StringReader(body));
            return obj as ResponseList<ItemProp>;
        }

        #endregion
    }

    /// <summary>
    /// 商品属性的XML响应解释器。
    /// </summary>
    public class ItemPropXmlParser : ITopParser<ItemProp>
    {
        #region ITopParser<ItemProp> Members

        public ItemProp Parse(string body)
        {
            ItemPropListXmlParser parser = new ItemPropListXmlParser();
            List<ItemProp> props = parser.Parse(body).Content;

            if (props != null && props.Count > 0)
            {
                return props[0];
            }
            else
            {
                return null;
            }
        }

        #endregion
    }

    /// <summary>
    /// 商品类目列表的XML响应解释器。
    /// </summary>
    public class ItemCatListXmlParser : ITopParser<ResponseList<ItemCategory>>
    {
        #region ITopParser<ResponseList<ItemCategory>> Members

        public ResponseList<ItemCategory> Parse(string body)
        {
            XmlAttributeOverrides attrs = ResponseList<ItemCategory>.GetOverrides("item_cat");
            XmlSerializer serializer = new XmlSerializer(typeof(ResponseList<ItemCategory>), attrs);

            object obj = serializer.Deserialize(new StringReader(body));
            return obj as ResponseList<ItemCategory>;
        }

        #endregion
    }

    /// <summary>
    /// 属性值列表的XML响应解释器。
    /// </summary>
    public class PropValueListXmlParser : ITopParser<ResponseList<PropValue>>
    {
        #region ITopParser<ResponseList<PropValue>> Members

        public ResponseList<PropValue> Parse(string body)
        {
            XmlAttributeOverrides attrs = ResponseList<PropValue>.GetOverrides("prop_value");
            XmlSerializer serializer = new XmlSerializer(typeof(ResponseList<PropValue>), attrs);

            object obj = serializer.Deserialize(new StringReader(body));
            return obj as ResponseList<PropValue>;
        }

        #endregion
    }
}
