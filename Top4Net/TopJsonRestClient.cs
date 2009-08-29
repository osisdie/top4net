using System;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api
{
    /// <summary>
    /// TOP基于REST的JSON客户端帮助类。
    /// </summary>
    public class TopJsonRestClient
    {
        private ITopClient client;

        public TopJsonRestClient(string topUrl, string appKey, string appSecret)
        {
            client = new TopRestClient(topUrl, appKey, appSecret, TopRestClient.FORMAT_JSON);
        }

        public string GetResponse(ITopRequest request)
        {
            return client.Execute(request, new StringParser());
        }

        public string GetResponse(ITopRequest request, string session)
        {
            return client.Execute(request, new StringParser(), session);
        }

        public User GetUser(UserGetRequest request)
        {
            return client.Execute(request, new UserJsonParser());
        }

        public User GetUser(UserGetRequest request, string session)
        {
            return client.Execute(request, new UserJsonParser(), session);
        }

        public ResponseList<User> GetUsers(UsersGetRequest request)
        {
            return client.Execute(request, new UserListJsonParser());
        }

        public Product GetProduct(ProductGetRequest request)
        {
            return client.Execute(request, new ProductJsonParser());
        }

        public ResponseList<Product> GetProducts(ProductsGetRequest request)
        {
            return client.Execute(request, new ProductListJsonParser());
        }

        public Product AddProduct(ProductAddRequest request, string session)
        {
            return client.Execute(request, new ProductJsonParser(), session);
        }

        public Product UpdateProduct(ProductUpdateRequest request, string session)
        {
            return client.Execute(request, new ProductJsonParser(), session);
        }

        public ResponseList<Product> SearchProducts(ProductsSearchRequest request)
        {
            return client.Execute(request, new ProductListJsonParser());
        }

        public ProductImg UploadProductImg(ProductImgUploadRequest request, string session)
        {
            return client.Execute(request, new ProductImgJsonParser(), session);
        }

        public ProductImg DeleteProductImg(ProductImgDeleteRequest request, string session)
        {
            return client.Execute(request, new ProductImgJsonParser(), session);
        }

        public ProductPropImg UploadProductPropImg(ProductPropImgUploadRequest request, string session)
        {
            return client.Execute(request, new ProductPropImgJsonParser(), session);
        }

        public ProductPropImg DeleteProductPropImg(ProductPropImgDeleteRequest request, string session)
        {
            return client.Execute(request, new ProductPropImgJsonParser(), session);
        }

        public ResponseList<ItemProp> GetItemProps(ItemPropsGetRequest request)
        {
            return client.Execute(request, new ItemPropListJsonParser());
        }

        public ResponseList<ItemCategory> GetItemCats(ItemCatsGetRequest request)
        {
            return client.Execute(request, new ItemCatListJsonParser());
        }

        public ResponseList<PropValue> GetItemPropValues(ItemPropValuesGetRequest request)
        {
            return client.Execute(request, new PropValueListJsonParser());
        }

        public ResponseList<ItemCategory> ListItemCats(ItemCatsListRequest request)
        {
            return client.Execute(request, new ItemCatListJsonParser());
        }

        public ResponseList<ItemProp> ListItemProps(ItemPropsListRequest request)
        {
            return client.Execute(request, new ItemPropListJsonParser());
        }

        public ItemProp ListItemProp(ItemPropListRequest request)
        {
            return client.Execute(request, new ItemPropJsonParser());
        }

        public Item GetItem(ItemGetRequest request)
        {
            return client.Execute(request, new ItemJsonParser());
        }

        public ResponseList<Item> GetItems(ItemsGetRequest request)
        {
            return client.Execute(request, new ItemListJsonParser());
        }

        public ResponseList<Item> GetCustomItems(ItemsCustomGetRequest request, string session)
        {
            return client.Execute(request, new ItemListJsonParser(), session);
        }

        public ResponseList<ItemSearch> SearchItems(ItemsSearchRequest request)
        {
            return client.Execute(request, new ItemSearchListJsonParser());
        }

        public ResponseList<Item> GetOnsaleItems(ItemsOnsaleGetRequest request, string session)
        {
            return client.Execute(request, new ItemListJsonParser(), session);
        }

        public ResponseList<Item> GetInstockItems(ItemsInstockGetRequest request, string session)
        {
            return client.Execute(request, new ItemListJsonParser(), session);
        }

        public ResponseList<Item> GetAllItems(ItemsAllGetRequest request, string session)
        {
            return client.Execute(request, new ItemListJsonParser(), session);
        }

        public Item UpdateItem(ItemUpdateRequest request, string session)
        {
            return client.Execute(request, new ItemJsonParser(), session);
        }

        public Item AddItem(ItemAddRequest request, string session)
        {
            return client.Execute(request, new ItemJsonParser(), session);
        }

        public Item DeleteItem(ItemDeleteRequest request, string session)
        {
            return client.Execute(request, new ItemJsonParser(), session);
        }

        public ItemImg UploadItemImg(ItemImgUploadRequest request, string session)
        {
            return client.Execute(request, new ItemImgJsonParser(), session);
        }

        public ItemImg DeleteItemImg(ItemImgDeleteRequest request, string session)
        {
            return client.Execute(request, new ItemImgJsonParser(), session);
        }

        public PropImg UploadItemPropImg(ItemPropImgUploadRequest request, string session)
        {
            return client.Execute(request, new PropImgJsonParser(), session);
        }

        public PropImg DeleteItemPropImg(ItemPropImgDeleteRequest request, string session)
        {
            return client.Execute(request, new PropImgJsonParser(), session);
        }

        public Sku GetItemSku(ItemSkuGetRequest request)
        {
            return client.Execute(request, new SkuJsonParser());
        }

        public ResponseList<Sku> GetItemSkus(ItemSkusGetRequest request)
        {
            return client.Execute(request, new SkuListJsonParser());
        }

        public ResponseList<Sku> GetCustomSkus(SkusCustomGetRequest request, string session)
        {
            return client.Execute(request, new SkuListJsonParser(), session);
        }

        public Sku AddItemSku(ItemSkuAddRequest request, string session)
        {
            return client.Execute(request, new SkuJsonParser(), session);
        }

        public Sku UpdateItemSku(ItemSkuUpdateRequest request, string session)
        {
            return client.Execute(request, new SkuJsonParser(), session);
        }

        public Item EnlistItem(ItemEnlistRequest request, string session)
        {
            return client.Execute(request, new ItemJsonParser(), session);
        }

        public Item DelistItem(ItemDelistRequest request, string session)
        {
            return client.Execute(request, new ItemJsonParser(), session);
        }

        public Item AddRecommendItem(ItemRecommendAddRequest request, string session)
        {
            return client.Execute(request, new ItemJsonParser(), session);
        }

        public Item DeleteRecommendItem(ItemRecommendDeleteRequest request, string session)
        {
            return client.Execute(request, new ItemJsonParser(), session);
        }

        public Postage GetPostage(PostageGetRequest request, string session)
        {
            return client.Execute(request, new PostageJsonParser(), session);
        }

        public Postage AddPostage(PostageAddRequest request, string session)
        {
            return client.Execute(request, new PostageJsonParser(), session);
        }

        public Postage UpdatePostage(PostageUpdateRequest request, string session)
        {
            return client.Execute(request, new PostageJsonParser(), session);
        }

        public Postage DeletePostage(PostageDeleteRequest request, string session)
        {
            return client.Execute(request, new PostageJsonParser(), session);
        }

        public ResponseList<Postage> GetPostages(PostagesGetRequest request, string session)
        {
            return client.Execute(request, new PostageListJsonParser(), session);
        }

        public ResponseList<TaobaokeItem> GetTaobaokeItems(TaobaokeItemsGetRequest request)
        {
            return client.Execute(request, new TaobaokeItemListJsonParser());
        }

        public ResponseList<TaobaokeItem> ConvertTaobaokeItems(TaobaokeItemsConvertRequest request)
        {
            return client.Execute(request, new TaobaokeItemListJsonParser());
        }

        public ResponseList<TaobaokeShop> ConvertTaobaokeShops(TaobaokeShopsConvertRequest request)
        {
            return client.Execute(request, new TaobaokeShopListJsonParser());
        }

        public string GetTaobaokeListUrl(TaobaokeListUrlGetRequest request)
        {
            return client.Execute(request, new TaobaokeListUrlJsonParser());
        }

        public Trade AddTrade(TradeAddRequest request, string session)
        {
            return client.Execute(request, new TradeJsonParser(), session);
        }

        public Trade GetTrade(TradeGetRequest request, string session)
        {
            return client.Execute(request, new TradeJsonParser(), session);
        }

        public Trade CloseTrade(TradeCloseRequest request, string session)
        {
            return client.Execute(request, new TradeJsonParser(), session);
        }

        public ResponseList<Trade> GetTrades(TradesGetRequest request)
        {
            return client.Execute(request, new TradeListJsonParser());
        }

        public Trade AddTradeMemo(TradeMemoAddRequest request, string session)
        {
            return client.Execute(request, new TradeJsonParser(), session);
        }

        public Trade UpdateTradeMemo(TradeMemoUpdateRequest request, string session)
        {
            return client.Execute(request, new TradeJsonParser(), session);
        }

        public Trade GetTradeDetail(TradeDetailGetRequest request, string session)
        {
            return client.Execute(request, new TradeJsonParser(), session);
        }

        public ResponseList<Trade> GetBoughtTrades(TradesBoughtGetRequest request, string session)
        {
            return client.Execute(request, new TradeListJsonParser(), session);
        }

        public ResponseList<Trade> GetSoldTrades(TradesSoldGetRequest request, string session)
        {
            return client.Execute(request, new TradeListJsonParser(), session);
        }

        public ResponseList<Order> GetOrders(OrdersGetRequest request)
        {
            return client.Execute(request, new OrderListJsonParser());
        }

        public Refund GetRefund(RefundGetRequest request, string session)
        {
            return client.Execute(request, new RefundJsonParser(), session);
        }

        public ResponseList<Refund> GetAppliedRefunds(RefundsAppliedGetRequest request, string session)
        {
            return client.Execute(request, new RefundListJsonParser(), session);
        }

        public ResponseList<Refund> GetReceivedRefunds(RefundsReceivedGetRequest request, string session)
        {
            return client.Execute(request, new RefundListJsonParser(), session);
        }

        public RefundMessage AddRefundMessage(RefundMessageAddRequest request, string session)
        {
            return client.Execute(request, new RefundMessageJsonParser(), session);
        }

        public ResponseList<RefundMessage> GetRefundMessages(RefundMessagesGetRequest request, string session)
        {
            return client.Execute(request, new RefundMessageListJsonParser(), session);
        }
    }
}
