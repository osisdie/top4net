using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// KbUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbUserInfo : TopObject
    {
        /// <summary>
        /// 地区名称
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// int 男:1 女:0 其它:2
        /// </summary>
        [XmlElement("gender")]
        public long Gender { get; set; }

        /// <summary>
        /// 用户等级
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// 用户默认头像
        /// </summary>
        [XmlElement("photo")]
        public string Photo { get; set; }

        /// <summary>
        /// 淘宝旺旺
        /// </summary>
        [XmlElement("tb_ww")]
        public string TbWw { get; set; }

        /// <summary>
        /// String not null 主键 数值型自增值(主站大部分应用使用),暂时由mysql生成
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名  String NOT NULL 一个中文占2个字符 UNIQUE KEY， 登录Handle
        /// </summary>
        [XmlElement("username")]
        public string Username { get; set; }
    }
}
