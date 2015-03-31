## Top4Net v0.10 ##
  1. Top4Net基础框架
  1. 添加[taobao.user.get](http://wiki.open.taobao.com/index.php/taobao.user.get)接口支持

## Top4Net v0.15 ##
  1. 接口ITopParser里面的GetParameters方法的返回类型改为接口
  1. 添加请求签名，支持正式环境调用
  1. 添加[taobao.users.get](http://wiki.open.taobao.com/index.php/taobao.users.get)接口支持

## Top4Net v0.20 ##
  1. 修正签名错误
  1. 添加产品类相关的对象和解释器
  1. 添加[taobao.products.search](http://wiki.open.taobao.com/index.php/taobao.products.search)接口支持

## Top4Net v0.22 ##
  1. 添加[taobao.product.get](http://wiki.open.taobao.com/index.php/taobao.product.get)接口支持
  1. 添加[taobao.products.get](http://wiki.open.taobao.com/index.php/taobao.products.get)接口支持

## Top4Net v0.23 ##
  1. 解决中文参数非法签名问题

## Top4Net v0.25 ##
  1. 支持带文件上传的API请求
  1. 添加[taobao.product.add](http://wiki.open.taobao.com/index.php/taobao.product.add)接口支持

## Top4Net v0.50 ##
  1. 重构Top4Net的请求体系
  1. 重构Top4Net的解释器体系
  1. 为入口类添加带会话的请求
  1. 为入口类添加使用解释方法委托的重载方法
  1. 添加所有TOP已经公开的API请求类
  1. 添加所有TOP已经公开的数据结构
  1. 支持所有商品属性相关的API
  1. 支持所有淘宝客相关的API
  1. 支持部分商品查询搜索相关的API

## Top4Net v0.60 ##
  1. 强类型化部分数字、日期，等参数
  1. 支持所有商品相关的API

## Top4Net v0.65 ##
  1. 使用可空对象避免数值类型的默认值问题
  1. 支持所有产品相关的API
  1. 添加TopJsonRestClient和TopXmlRestClient两个工具类

## Top4Net v0.70 ##
  1. 支持所有交易相关的API
  1. 支持所有退款相关的API

## Top4Net v0.75 ##
  1. 支持部分未正式公开的交易API
  1. 支持所有物流相关的API

## Top4Net v0.80 ##
  1. 支持所有店铺相关的API

## Top4Net v0.85 ##
  1. 修改文件上传接口以支持通过字节数组来调用带文件上传的API
  1. 修正部分映射错误

## Top4Net v0.86 ##
  1. 修正带文件上传的API不传文件时抛空指针错误的问题

## Top4Net v0.90 ##
  1. 同步09月28号改名的API
  1. 增加容器回调验证相关的方法
  1. 新增两个API
  1. 优化部分代码

## Top4Net v0.91 ##
  1. 更新JSON.NET到3.5稳定版，并采用纯.NET 2.0版本
  1. 添加支持获取taobao.item.get的隐私数据方法

## Top4Net v1.0 ##
  1. 修正全部字段映射错误
  1. 增加获取B商家授权类目API

## Top4Net v2.0.0 ##
  1. ResponseList改名为PageList
  1. TopXmlRestClient中的所有方法名称已经改为和API名称一致
  1. 数据结构中的字段已经改为和官方公布的数据结构一致
  1. 支持自用型应用不需要传SessionKey参数

## Top4Net v2.0.1 ##
  1. 缓存序列化器，提升了接近一倍的解释速度
  1. 修正部分字段的数据类型

## Top4Net v2.0.2 ##
  1. 添加DynamicTopRequest来支持动态请求
  1. 过滤XML返回中的非法字符

## Top4Net v2.1.0 ##
  1. 同步到最新的TOPAPI（num\_iid等）

## Top4Net v2.1.1 ##
  1. 缓存反序列化器，解决内存溢出问题
  1. 增加taobao.delivery.cod.send

## Top4Net v2.1.2 ##
  1. 同步API最新改动
  1. 添加收藏夹API