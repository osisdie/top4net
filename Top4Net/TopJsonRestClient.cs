﻿using System;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api
{
    /// <summary>
    /// TOP基于REST的JSON客户端帮助类。
    /// </summary>
    /// <example><c>
    /// TopJsonRestClient client = new TopJsonRestClient("http://gw.sandbox.taobao.com/router/rest", "test", "test");
    /// UserGetRequest request = new UserGetRequest();
    /// request.Fields = "user_id,nick,sex,created,location";
    /// request.Nick = "tbtest520";
    /// User user = client.GetUser(request);
    /// </c></example>
    public class TopJsonRestClient
    {
        private ITopClient client;

        public TopJsonRestClient(string topUrl, string appKey, string appSecret)
        {
            client = new TopRestClient(topUrl, appKey, appSecret, TopRestClient.FORMAT_JSON);
        }

        /// <summary>
        /// All TOP APIs
        /// </summary>
        public string GetResponse(ITopRequest request)
        {
            return client.Execute(request, new StringParser());
        }

        /// <summary>
        /// All TOP APIs
        /// </summary>
        public string GetResponse(ITopRequest request, string session)
        {
            return client.Execute(request, new StringParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.user.get
        /// </summary>
        public User GetUser(UserGetRequest request)
        {
            return client.Execute(request, new UserJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.user.get
        /// </summary>
        public User GetUser(UserGetRequest request, string session)
        {
            return client.Execute(request, new UserJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.users.get
        /// </summary>
        public ResponseList<User> GetUsers(UsersGetRequest request)
        {
            return client.Execute(request, new UserListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.product.get
        /// </summary>
        public Product GetProduct(ProductGetRequest request)
        {
            return client.Execute(request, new ProductJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.products.get
        /// </summary>
        public ResponseList<Product> GetProducts(ProductsGetRequest request)
        {
            return client.Execute(request, new ProductListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.product.add
        /// </summary>
        public Product AddProduct(ProductAddRequest request, string session)
        {
            return client.Execute(request, new ProductJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.product.update
        /// </summary>
        public Product UpdateProduct(ProductUpdateRequest request, string session)
        {
            return client.Execute(request, new ProductJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.products.search
        /// </summary>
        public ResponseList<Product> SearchProducts(ProductsSearchRequest request)
        {
            return client.Execute(request, new ProductListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.product.img.upload
        /// </summary>
        public ProductImg UploadProductImg(ProductImgUploadRequest request, string session)
        {
            return client.Execute(request, new ProductImgJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.product.img.delete
        /// </summary>
        public ProductImg DeleteProductImg(ProductImgDeleteRequest request, string session)
        {
            return client.Execute(request, new ProductImgJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.product.propimg.upload
        /// </summary>
        public ProductPropImg UploadProductPropImg(ProductPropImgUploadRequest request, string session)
        {
            return client.Execute(request, new ProductPropImgJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.product.propimg.delete
        /// </summary>
        public ProductPropImg DeleteProductPropImg(ProductPropImgDeleteRequest request, string session)
        {
            return client.Execute(request, new ProductPropImgJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.itemprops.get.v2
        /// </summary>
        public ResponseList<ItemProp> GetItemProps(ItemPropsGetRequest request)
        {
            return client.Execute(request, new ItemPropListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.itemcats.get.v2
        /// </summary>
        public ResponseList<ItemCategory> GetItemCats(ItemCatsGetRequest request)
        {
            return client.Execute(request, new ItemCatListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.itempropvalues.get
        /// </summary>
        public ResponseList<PropValue> GetItemPropValues(ItemPropValuesGetRequest request)
        {
            return client.Execute(request, new PropValueListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.itemcats.list.get
        /// </summary>
        public ResponseList<ItemCategory> ListItemCats(ItemCatsListRequest request)
        {
            return client.Execute(request, new ItemCatListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.itemprops.list.get
        /// </summary>
        public ResponseList<ItemProp> ListItemProps(ItemPropsListRequest request)
        {
            return client.Execute(request, new ItemPropListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.itemprop.list.get
        /// </summary>
        public ItemProp ListItemProp(ItemPropListRequest request)
        {
            return client.Execute(request, new ItemPropJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.item.get
        /// </summary>
        public Item GetItem(ItemGetRequest request)
        {
            return client.Execute(request, new ItemJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.items.get
        /// </summary>
        public ResponseList<Item> GetItems(ItemsGetRequest request)
        {
            return client.Execute(request, new ItemListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.fullitems.get
        /// </summary>
        public ResponseList<Item> GetCustomItems(ItemsCustomGetRequest request, string session)
        {
            return client.Execute(request, new ItemListJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.items.search
        /// </summary>
        public ResponseList<ItemSearch> SearchItems(ItemsSearchRequest request)
        {
            return client.Execute(request, new ItemSearchListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.items.onsale.get
        /// </summary>
        public ResponseList<Item> GetOnsaleItems(ItemsOnsaleGetRequest request, string session)
        {
            return client.Execute(request, new ItemListJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.items.instock.get
        /// </summary>
        public ResponseList<Item> GetInstockItems(ItemsInstockGetRequest request, string session)
        {
            return client.Execute(request, new ItemListJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.items.all.get
        /// </summary>
        public ResponseList<Item> GetAllItems(ItemsAllGetRequest request, string session)
        {
            return client.Execute(request, new ItemListJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.item.update
        /// </summary>
        public Item UpdateItem(ItemUpdateRequest request, string session)
        {
            return client.Execute(request, new ItemJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.item.add
        /// </summary>
        public Item AddItem(ItemAddRequest request, string session)
        {
            return client.Execute(request, new ItemJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.item.delete
        /// </summary>
        public Item DeleteItem(ItemDeleteRequest request, string session)
        {
            return client.Execute(request, new ItemJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.item.img.upload
        /// </summary>
        public ItemImg UploadItemImg(ItemImgUploadRequest request, string session)
        {
            return client.Execute(request, new ItemImgJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.item.img.delete
        /// </summary>
        public ItemImg DeleteItemImg(ItemImgDeleteRequest request, string session)
        {
            return client.Execute(request, new ItemImgJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.item.propimg.upload
        /// </summary>
        public PropImg UploadItemPropImg(ItemPropImgUploadRequest request, string session)
        {
            return client.Execute(request, new PropImgJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.item.propimg.delete
        /// </summary>
        public PropImg DeleteItemPropImg(ItemPropImgDeleteRequest request, string session)
        {
            return client.Execute(request, new PropImgJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.item.sku.get
        /// </summary>
        public Sku GetItemSku(ItemSkuGetRequest request)
        {
            return client.Execute(request, new SkuJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.item.skus.get
        /// </summary>
        public ResponseList<Sku> GetItemSkus(ItemSkusGetRequest request)
        {
            return client.Execute(request, new SkuListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.fullskus.get
        /// </summary>
        public ResponseList<Sku> GetCustomSkus(SkusCustomGetRequest request, string session)
        {
            return client.Execute(request, new SkuListJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.item.sku.add
        /// </summary>
        public Sku AddItemSku(ItemSkuAddRequest request, string session)
        {
            return client.Execute(request, new SkuJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.item.sku.update
        /// </summary>
        public Sku UpdateItemSku(ItemSkuUpdateRequest request, string session)
        {
            return client.Execute(request, new SkuJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.item.update.listing
        /// </summary>
        public Item EnlistItem(ItemEnlistRequest request, string session)
        {
            return client.Execute(request, new ItemJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.item.update.delisting
        /// </summary>
        public Item DelistItem(ItemDelistRequest request, string session)
        {
            return client.Execute(request, new ItemJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.item.update.showcase
        /// </summary>
        public Item AddRecommendItem(ItemRecommendAddRequest request, string session)
        {
            return client.Execute(request, new ItemJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.item.update.revokeShowcase
        /// </summary>
        public Item DeleteRecommendItem(ItemRecommendDeleteRequest request, string session)
        {
            return client.Execute(request, new ItemJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.postage.get
        /// </summary>
        public Postage GetPostage(PostageGetRequest request, string session)
        {
            return client.Execute(request, new PostageJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.postage.add
        /// </summary>
        public Postage AddPostage(PostageAddRequest request, string session)
        {
            return client.Execute(request, new PostageJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.postage.update
        /// </summary>
        public Postage UpdatePostage(PostageUpdateRequest request, string session)
        {
            return client.Execute(request, new PostageJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.postage.delete
        /// </summary>
        public Postage DeletePostage(PostageDeleteRequest request, string session)
        {
            return client.Execute(request, new PostageJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.postages.get
        /// </summary>
        public ResponseList<Postage> GetPostages(PostagesGetRequest request, string session)
        {
            return client.Execute(request, new PostageListJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.taobaoke.items.get
        /// </summary>
        public ResponseList<TaobaokeItem> GetTaobaokeItems(TaobaokeItemsGetRequest request)
        {
            return client.Execute(request, new TaobaokeItemListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.taobaoke.items.convert
        /// </summary>
        public ResponseList<TaobaokeItem> ConvertTaobaokeItems(TaobaokeItemsConvertRequest request)
        {
            return client.Execute(request, new TaobaokeItemListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.taobaoke.shops.convert
        /// </summary>
        public ResponseList<TaobaokeShop> ConvertTaobaokeShops(TaobaokeShopsConvertRequest request)
        {
            return client.Execute(request, new TaobaokeShopListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.taobaoke.listurl.get
        /// </summary>
        public string GetTaobaokeListUrl(TaobaokeListUrlGetRequest request)
        {
            return client.Execute(request, new TaobaokeListUrlJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.trade.nbsadd
        /// </summary>
        public Trade AddTrade(TradeAddRequest request, string session)
        {
            return client.Execute(request, new TradeJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.trade.get
        /// </summary>
        public Trade GetTrade(TradeGetRequest request, string session)
        {
            return client.Execute(request, new TradeJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.trade.close
        /// </summary>
        public Trade CloseTrade(TradeCloseRequest request, string session)
        {
            return client.Execute(request, new TradeJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.trades.get
        /// </summary>
        public ResponseList<Trade> GetTrades(TradesGetRequest request)
        {
            return client.Execute(request, new TradeListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.trade.memo.add
        /// </summary>
        public Trade AddTradeMemo(TradeMemoAddRequest request, string session)
        {
            return client.Execute(request, new TradeJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.trade.memo.update
        /// </summary>
        public Trade UpdateTradeMemo(TradeMemoUpdateRequest request, string session)
        {
            return client.Execute(request, new TradeJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.trade.fullinfo.get
        /// </summary>
        public Trade GetTradeDetail(TradeDetailGetRequest request, string session)
        {
            return client.Execute(request, new TradeJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.trades.bought.get
        /// </summary>
        public ResponseList<Trade> GetBoughtTrades(TradesBoughtGetRequest request, string session)
        {
            return client.Execute(request, new TradeListJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.trades.sold.get
        /// </summary>
        public ResponseList<Trade> GetSoldTrades(TradesSoldGetRequest request, string session)
        {
            return client.Execute(request, new TradeListJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.orders.get
        /// </summary>
        public ResponseList<Order> GetOrders(OrdersGetRequest request)
        {
            return client.Execute(request, new OrderListJsonParser());
        }

        /// <summary>
        /// TOP API: taobao.refund.get
        /// </summary>
        public Refund GetRefund(RefundGetRequest request, string session)
        {
            return client.Execute(request, new RefundJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.refunds.apply.get
        /// </summary>
        public ResponseList<Refund> GetAppliedRefunds(RefundsAppliedGetRequest request, string session)
        {
            return client.Execute(request, new RefundListJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.refunds.receive.get
        /// </summary>
        public ResponseList<Refund> GetReceivedRefunds(RefundsReceivedGetRequest request, string session)
        {
            return client.Execute(request, new RefundListJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.refund.message.add
        /// </summary>
        public RefundMessage AddRefundMessage(RefundMessageAddRequest request, string session)
        {
            return client.Execute(request, new RefundMessageJsonParser(), session);
        }

        /// <summary>
        /// TOP API: taobao.refund.messages.get
        /// </summary>
        public ResponseList<RefundMessage> GetRefundMessages(RefundMessagesGetRequest request, string session)
        {
            return client.Execute(request, new RefundMessageListJsonParser(), session);
        }
    }
}
