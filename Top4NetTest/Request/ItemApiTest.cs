using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;

namespace Taobao.Top.Api.Test.Request
{
    [TestClass]
    public class ItemApiTest
    {
        [TestMethod]
        public void GetItemPropsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            ItemPropsGetRequest req = new ItemPropsGetRequest();
            req.Fields = "pid,name,status,sort_order,parent_pid,is_key_prop,is_sale_prop,is_color_prop,is_item_prop";
            req.LeafCid = "1101"; //笔记本类目编号
            string rsp = client.Execute(req, new StringParser());
            Console.WriteLine(rsp);
        }
    }
}
