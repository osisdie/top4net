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

        public User getUser(ITopRequest request, string session)
        {
            return client.Execute(request, new UserJsonParser(), session);
        }

        public ResponseList<User> getUsers(ITopRequest request)
        {
            return client.Execute(request, new UserListJsonParser());
        }
    }
}
