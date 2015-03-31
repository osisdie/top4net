### Top4Net新接口开发流程 ###
  1. 编写领域对象
  1. 编写领域对象的解释器（JSON和XML版本）
  1. 编写解释器的测试类（JSON和XML至少各一个）
  1. 编写请求类
  1. 编写请求类的测试类（JSON和XML至少各一个）

### 开发示例（taobao.user.get） ###
  1. 编写User对象
  1. 编写UserJsonParser和UserXmlParser解释器
  1. 编写ParseUserByJson和ParseUserByXml测试方法
  1. 编写UserGetRequest请求
  1. 编写GetUserByJson和GetUserByXml测试方法