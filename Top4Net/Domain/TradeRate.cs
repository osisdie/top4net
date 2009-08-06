using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 评价信息
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot( "tradeRate" )]
    class TradeRate
    {
        /// <summary>
        /// 交易ID
        /// </summary>
        [JsonProperty( "tid" )]
        [XmlElement( "tid" )]
        public string Tid { get; set; }

        /// <summary>
        /// 子订单ID
        /// </summary>
        [JsonProperty( "order_id" )]
        [XmlElement( "order_id" )]
        public string OrderId { get; set; }

        /// <summary>
        /// 评价者角色.可选值:seller(卖家),buyer(买家)
        /// </summary>
        [JsonProperty( "role" )]
        [XmlElement( "role" )]
        public string Role { get; set; }

        /// <summary>
        /// 评价者昵称
        /// </summary>
        [JsonProperty( "nick" )]
        [XmlElement( "nick" )]
        public string Nick { get; set; }

        /// <summary>
        /// 评价结果,可选值:good(好评),neutral(中评),bad(差评)
        /// </summary>
        [JsonProperty( "result" )]
        [XmlElement( "result" )]
        public string Result { get; set; }

        /// <summary>
        /// 评价创建时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty( "created" )]
        [XmlElement( "created" )]
        public DateTime Created { get; set; }

        /// <summary>
        /// 被评价者昵称
        /// </summary>
        [JsonProperty( "rated_nick" )]
        [XmlElement( "rated_nick" )]
        public string RatedNick { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [JsonProperty( "item_title" )]
        [XmlElement( "item_title" )]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 商品价格,精确到2位小数
        /// </summary>
        [JsonProperty( "item_price" )]
        [XmlElement( "item_price" )]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 评价内容,最大长度:500个汉字
        /// </summary>
        [JsonProperty( "content" )]
        [XmlElement( "content" )]
        public string Content { get; set; }

        /// <summary>
        /// 评价解释,最大长度:500个汉字
        /// </summary>
        [JsonProperty( "reply" )]
        [XmlElement( "reply" )]
        public string Reply { get; set; }


    }
}
