using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    public class UserGetRequest : ITopRequest
    {
        public string Fields { get; set; }
        public string Nick { get; set; }

        public string GetApiName()
        {
            return "taobao.user.get";
        }

        public Dictionary<string, string> GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", Fields);
            parameters.Add("nick", Nick);

            return parameters;
        }
    }
}
