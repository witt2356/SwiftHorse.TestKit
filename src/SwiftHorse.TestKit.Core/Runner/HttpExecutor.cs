using Newtonsoft.Json;
using SwiftHorse.TestKit.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core.Runner
{
    internal class HttpExecutor
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HttpExecutor(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<HttpResponseMessage> SendAsync(string host, TestCaseDto testCase)
        {
            var httpMethod = new HttpMethod(testCase.HttpMethod);
            var message = new HttpRequestMessage(httpMethod, BuildUrl(testCase))
            {
                Content = BuildContent(testCase)
            };
            //message.Headers.Add("Authorization", IOCContainer.Resolve<ITokenAccessor>().Get());
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(host);
            return await client.SendAsync(message);
        }

        private string BuildUrl(TestCaseDto testCase)
        {
            var url = testCase.Url;
            if (new Regex("{\\d+}").IsMatch(url))
            {
                return string.Format(url, testCase.Data.Split(','));
            }
            if (testCase.ContentType == ContentTypes.Url)
            {
                url = $"{url}?{testCase.Data}";
            }
            return url;
        }

        private HttpContent BuildContent(TestCaseDto testCase)
        {
            if (testCase.ContentType == ContentTypes.Json || testCase.ContentType == ContentTypes.FormUrlencoded)
            {
                return new StringContent(testCase.Data, Encoding.UTF8, testCase.ContentType);
            }
            return null;
        }
    }

    internal class HttpRequestInfo
    {
        public string Url { get; set; }
        public string Method { get; set; }
        public string Data { get; set; }
        public HttpContent Content { get; set; }

        public HttpRequestInfo(string url)
        {
            Url = url;
        }
    }
}
