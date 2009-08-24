using System;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api
{
    /// <summary>
    /// TOP基于REST的XML客户端帮助类。
    /// </summary>
    public class TopXmlRestClient
    {
        private ITopClient client;

        public TopXmlRestClient(string topUrl, string appKey, string appSecret)
        {
            client = new TopRestClient(topUrl, appKey, appSecret, TopRestClient.FORMAT_XML);
        }

        public User GetUser(UserGetRequest request, string session)
        {
            return client.Execute(request, new UserXmlParser(), session);
        }

        public ResponseList<User> GetUsers(UsersGetRequest request)
        {
            return client.Execute(request, new UserListXmlParser());
        }

        public Product GetProduct(ProductGetRequest request)
        {
            return client.Execute(request, new ProductXmlParser());
        }

        public ResponseList<Product> GetProducts(ProductsGetRequest request)
        {
            return client.Execute(request, new ProductListXmlParser());
        }

        public Product AddProduct(ProductAddRequest request, string session)
        {
            return client.Execute(request, new ProductXmlParser(), session);
        }

        public Product UpdateProduct(ProductUpdateRequest request, string session)
        {
            return client.Execute(request, new ProductXmlParser(), session);
        }

        public ResponseList<Product> SearchProducts(ProductsSearchRequest request)
        {
            return client.Execute(request, new ProductListXmlParser());
        }

        public ProductImg UploadProductImg(ProductImgUploadRequest request, string session)
        {
            return client.Execute(request, new ProductImgXmlParser(), session);
        }

        public ProductImg DeleteProductImg(ProductImgDeleteRequest request, string session)
        {
            return client.Execute(request, new ProductImgXmlParser(), session);
        }

        public ProductPropImg UploadProductPropImg(ProductPropImgUploadRequest request, string session)
        {
            return client.Execute(request, new ProductPropImgXmlParser(), session);
        }

        public ProductPropImg DeleteProductPropImg(ProductPropImgDeleteRequest request, string session)
        {
            return client.Execute(request, new ProductPropImgXmlParser(), session);
        }

        public ResponseList<ItemProp> GetItemProps(ItemPropsGetRequest request)
        {
            return client.Execute(request, new ItemPropListXmlParser());
        }

        public ResponseList<ItemCategory> GetItemCats(ItemCatsGetRequest request)
        {
            return client.Execute(request, new ItemCatListXmlParser());
        }

        public ResponseList<PropValue> GetItemPropValues(ItemPropValuesGetRequest request)
        {
            return client.Execute(request, new PropValueListXmlParser());
        }

        public ResponseList<ItemCategory> ListItemCats(ItemCatsListRequest request)
        {
            return client.Execute(request, new ItemCatListXmlParser());
        }

        public ResponseList<ItemProp> ListItemProps(ItemPropsListRequest request)
        {
            return client.Execute(request, new ItemPropListXmlParser());
        }

        public ItemProp ListItemProp(ItemPropListRequest request)
        {
            return client.Execute(request, new ItemPropXmlParser());
        }

        public Item GetItem(ItemGetRequest request)
        {
            return client.Execute(request, new ItemXmlParser());
        }

        public ResponseList<Item> GetItems(ItemsGetRequest request)
        {
            return client.Execute(request, new ItemListXmlParser());
        }

        public ResponseList<ItemSearch> SearchItems(ItemsSearchRequest request)
        {
            return client.Execute(request, new ItemSearchListXmlParser());
        }

        public ResponseList<Item> GetOnsaleItems(ItemsOnsaleGetRequest request, string session)
        {
            return client.Execute(request, new ItemListXmlParser(), session);
        }

        public ResponseList<Item> GetAllItems(ItemsAllGetRequest request, string session)
        {
            return client.Execute(request, new ItemListXmlParser(), session);
        }

        public Item UpdateItem(ItemUpdateRequest request, string session)
        {
            return client.Execute(request, new ItemXmlParser(), session);
        }

        public Item AddItem(ItemAddRequest request, string session)
        {
            return client.Execute(request, new ItemXmlParser(), session);
        }

        public Item DeleteItem(ItemDeleteRequest request, string session)
        {
            return client.Execute(request, new ItemXmlParser(), session);
        }

        public ItemImg UploadItemImg(ItemImgUploadRequest request, string session)
        {
            return client.Execute(request, new ItemImgXmlParser(), session);
        }

        public ItemImg DeleteItemImg(ItemImgDeleteRequest request, string session)
        {
            return client.Execute(request, new ItemImgXmlParser(), session);
        }

        public PropImg UploadItemPropImg(ItemPropImgUploadRequest request, string session)
        {
            return client.Execute(request, new PropImgXmlParser(), session);
        }

        public PropImg DeleteItemPropImg(ItemPropImgDeleteRequest request, string session)
        {
            return client.Execute(request, new PropImgXmlParser(), session);
        }

        public Sku GetItemSku(ItemSkuGetRequest request)
        {
            return client.Execute(request, new SkuXmlParser());
        }

        public ResponseList<Sku> GetItemSkus(ItemSkusGetRequest request)
        {
            return client.Execute(request, new SkuListXmlParser());
        }

        public Sku AddItemSku(ItemSkuAddRequest request, string session)
        {
            return client.Execute(request, new SkuXmlParser(), session);
        }

        public Sku UpdateItemSku(ItemSkuUpdateRequest request, string session)
        {
            return client.Execute(request, new SkuXmlParser(), session);
        }

        public Item EnlistItem(ItemEnlistRequest request, string session)
        {
            return client.Execute(request, new ItemXmlParser(), session);
        }

        public Item DelistItem(ItemDelistRequest request, string session)
        {
            return client.Execute(request, new ItemXmlParser(), session);
        }

        public Postage GetPostage(PostageGetRequest request, string session)
        {
            return client.Execute(request, new PostageXmlParser(), session);
        }

        public Postage AddPostage(PostageAddRequest request, string session)
        {
            return client.Execute(request, new PostageXmlParser(), session);
        }

        public Postage UpdatePostage(PostageUpdateRequest request, string session)
        {
            return client.Execute(request, new PostageXmlParser(), session);
        }

        public Postage DeletePostage(PostageDeleteRequest request, string session)
        {
            return client.Execute(request, new PostageXmlParser(), session);
        }

        public ResponseList<Postage> GetPostages(PostagesGetRequest request, string session)
        {
            return client.Execute(request, new PostageListXmlParser(), session);
        }

        public ResponseList<TaobaokeItem> GetTaobaokeItems(TaobaokeItemsGetRequest request)
        {
            return client.Execute(request, new TaobaokeItemListXmlParser());
        }

        public ResponseList<TaobaokeItem> ConvertTaobaokeItems(TaobaokeItemsConvertRequest request)
        {
            return client.Execute(request, new TaobaokeItemListXmlParser());
        }

        public ResponseList<TaobaokeShop> ConvertTaobaokeShops(TaobaokeShopsConvertRequest request)
        {
            return client.Execute(request, new TaobaokeShopListXmlParser());
        }

        public string GetTaobaokeListUrl(TaobaokeListUrlGetRequest request)
        {
            return client.Execute(request, new TaobaokeListUrlXmlParser());
        }
    }
}
