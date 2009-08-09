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
    public class ItemPropListXmlParser : ITopParser<List<ItemProp>>
    {
        #region ITopParser<List<ItemProp>> Members

        public List<ItemProp> Parse(string body)
        {
            TopListResponse<ItemProp> topRsp = new TopListResponse<ItemProp>("item_prop");
            XmlSerializer serializer = new XmlSerializer(typeof(TopListResponse<ItemProp>), topRsp.GetOverrides());

            object obj = serializer.Deserialize(new StringReader(body));
            TopListResponse<ItemProp> rsp = obj as TopListResponse<ItemProp>;
            return rsp == null ? null : rsp.Content;
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
            List<ItemProp> props = parser.Parse(body);

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
    public class ItemCatListXmlParser : ITopParser<List<ItemCategory>>
    {
        #region ITopParser<List<ItemCategory>> Members

        public List<ItemCategory> Parse(string body)
        {
            TopListResponse<ItemCategory> topRsp = new TopListResponse<ItemCategory>("item_cat");
            XmlSerializer serializer = new XmlSerializer(typeof(TopListResponse<ItemCategory>), topRsp.GetOverrides());

            object obj = serializer.Deserialize(new StringReader(body));
            TopListResponse<ItemCategory> rsp = obj as TopListResponse<ItemCategory>;
            return rsp == null ? null : rsp.Content;
        }

        #endregion
    }

    /// <summary>
    /// 属性值列表的XML响应解释器。
    /// </summary>
    public class PropValueListXmlParser : ITopParser<List<PropValue>>
    {
        #region ITopParser<List<PropValue>> Members

        public List<PropValue> Parse(string body)
        {
            TopListResponse<PropValue> topRsp = new TopListResponse<PropValue>("prop_value");
            XmlSerializer serializer = new XmlSerializer(typeof(TopListResponse<PropValue>), topRsp.GetOverrides());

            object obj = serializer.Deserialize(new StringReader(body));
            TopListResponse<PropValue> rsp = obj as TopListResponse<PropValue>;
            return rsp == null ? null : rsp.Content;
        }

        #endregion
    }
}
