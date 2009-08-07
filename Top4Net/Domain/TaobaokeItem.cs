using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 淘宝客商品
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot( "taobaokeItem" )]
    public class TaobaokeItem
    {
        /// <summary>
        /// 淘宝客商品id
        /// </summary>
        [JsonProperty( "iid" )]
        [XmlElement( "iid" )]
        public string ItemId { get; set; }
        /// <summary>
        /// 商品title宝贝名称
        /// </summary>
        [JsonProperty( "title" )]
        [XmlElement( "title" )]
        public string Title { get; set; }
        /// <summary>
        /// 卖家昵称
        /// </summary>
        [JsonProperty( "nick" )]
        [XmlElement( "nick" )]
        public string Nick { get; set; }
        /// <summary>
        /// 图片url
        /// </summary>
        [JsonProperty( "pic_url" )]
        [XmlElement( "pic_url" )]
        public string PicUrl { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        [JsonProperty( "price" )]
        [XmlElement( "price" )]
        public string Price { get; set; }
        /// <summary>
        /// 推广点击url
        /// </summary>
        [JsonProperty( "click_url" )]
        [XmlElement( "click_url" )]
        public string ClickUrl { get; set; }
        /// <summary>
        /// 淘宝客佣金
        /// </summary>
        [JsonProperty( "commission" )]
        [XmlElement( "commission" )]
        public string Commission { get; set; }
        /// <summary>
        /// 淘宝客佣金比率
        /// </summary>
        [JsonProperty( "commission_rate" )]
        [XmlElement( "commission_rate" )]
        public string CommissionRate { get; set; }
        /// <summary>
        /// 累计成交量
        /// </summary>
        [JsonProperty( "commission_num" )]
        [XmlElement( "commission_num" )]
        public string CommissionNum { get; set; }
        /// <summary>
        /// 累计总支出佣金量
        /// </summary>
        [JsonProperty( "commission_volume" )]
        [XmlElement( "commission_volume" )]
        public string CommissionVolume { get; set; }
    }
}
