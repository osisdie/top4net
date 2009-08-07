
using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test
{
    [TestClass]
    public class TaobaokeItemApiTest
    {
        //TODO: not passed
        [TestMethod]
        public void GetTaobaokeItemsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient( "json" );
            TaobaokeItemsGetRequest request = new TaobaokeItemsGetRequest();
            request.Fields = "iid,title,nick,pic_url,price,click_url,commission,commission_rate,commission_num,commission_volume";
            request.PartnerId = "sns";
            request.Keyword = "sns";
            request.StartPrice = "100";
            request.EndPrice = "200";
            request.AutoSend = "false";
            request.Area = "杭州";
            request.StartCredit = "1crown";
            request.EndCredit = "3crown";
            request.Sort = "commissionNum_desc";
            request.IsGuarantee = "true";
            request.PageSize = "30";
            request.PageNo = "1";
            List<TaobaokeItem> taobaokeItems = client.Execute( request, new TaobaokeItemListJsonParser() );
            Assert.AreEqual( 30, taobaokeItems.Count );
        }

        [TestMethod]
        public void GetTaobaokeItemsByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient( "xml" );
            TaobaokeItemsGetRequest request = new TaobaokeItemsGetRequest();
            request.Fields = "iid,title,nick,pic_url,price,click_url,commission,commission_rate,commission_num,commission_volume";
            request.PartnerId = "12345678_0_0";
            request.Keyword = "test";
            request.PageSize = "30";

            List<TaobaokeItem> taobaokeItems = client.Execute( request, new TaobaokeItemListXmlParser() );
            Assert.AreEqual( 30, taobaokeItems.Count );
            //AssertTaobaokeItem( taobaokeItems[0] );
        }

        private void AssertTaobaokeItem(TaobaokeItem taobaokeItem)
        {
            Assert.AreEqual( "72b31835f55b6b6c35beab8c753989c1", taobaokeItem.ItemId );
            Assert.AreEqual( "淘宝客测试数据商品名称:1", taobaokeItem.Title );
            Assert.AreEqual( "http://img.taobao.com/bao/uploaded/i2/T1SxBeXg5XMdMUfdMZ_031728.jpg", taobaokeItem.PicUrl );
            Assert.AreEqual( "100", taobaokeItem.Price );
            Assert.AreEqual( "http://s.click.alimama.com/ma_a?e=7TbRJUSX6oob60193a32e1ad654", taobaokeItem.ClickUrl );
            Assert.AreEqual( "淘宝客测试数据卖家昵称:1", taobaokeItem.Nick );
            Assert.AreEqual( "22.05", taobaokeItem.Commission );
            Assert.AreEqual( "350.00", taobaokeItem.CommissionRate );
            Assert.AreEqual( "10", taobaokeItem.CommissionNum );
            Assert.AreEqual( "54", taobaokeItem.CommissionVolume );
        }
    }
}