## 设计原则 ##
  1. 容易维护扩展（不需要修改主类就可以添加新的API支持）
  1. 注入型解释器（依据不同的返回格式注入相应的解释器）
  1. 集中管理请求参数与参数映射
  1. 使用泛型来做强类型编程
  1. 基于纯.NET 2.0的XML与JSON解释器实现
  1. 多协议扩展支持（REST, RPC, SOAP, etc）
## 设计类图 ##
![http://top4net.googlecode.com/files/Top4Net.png](http://top4net.googlecode.com/files/Top4Net.png)
## 扩展方式 ##
  1. 实现ITopRequest类，覆盖其中的GetParameters和GetApiName方法
  1. 实现ITopParser类，覆盖其中的Parse方法。
## 环境依赖 ##
  * 需要运行在.NET Framework 2.0的环境或者以上
## 调用方式 ##
```
TopXmlRestClient client = new TopXmlRestClient("http://gw.api.tbsandbox.com/router/rest", "test", "test");
UserGetRequest request = new UserGetRequest();
request.Fields = "user_id,nick,sex,created,location";
request.Nick = "tbtest520";
User user = client.UserGet(request);
```
```
TopXmlRestClient client = new TopXmlRestClient("http://gw.api.tbsandbox.com/router/rest", "test", "test");
ItemUpdateRequest request = new ItemUpdateRequest();
request.Iid = "9ce7d2a5a38c1a20346cdd4af6f90de3";
request.Title = "Updated by Top4Net";
request.Image = new FileItem(new FileInfo("C:/temp.jpg"));
Item item = client.ItemUpdate(request, "session_key");
```
```
TopXmlRestClient client = new TopXmlRestClient("http://gw.api.tbsandbox.com/router/rest", "test", "test");
TradesSoldGetRequest req = new TradesSoldGetRequest();
req.Fields = "tid,seller_nick,buyer_nick,orders.oid,orders.iid,orders.title,orders.price";
PageList<Trade> rsp = client.TradesSoldGet(req, "session_key");
List<Trade> trades = rsp.Content;
long totalResults = rsp.TotalResults;
```
```
 ITopClient client = new TopRestClient("http://gw.api.tbsandbox.com/router/rest", "test", "test", "json");
 UserGetRequest request = new UserGetRequest();
 request.Fields = "user_id,nick,sex,created,location";
 request.Nick = "tbtest520";
 User user = client.Execute(request, new ObjectXmlParser<User>(new ParseData(request.getApiName(), "user")));
```