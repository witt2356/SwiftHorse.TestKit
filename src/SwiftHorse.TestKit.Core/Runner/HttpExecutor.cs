using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core.Runner
{
    internal class HttpExecutor
    {
        private readonly string _host;

        public HttpExecutor(string host)
        {
            _host = host;
        }

        public async Task<HttpResponseMessage> SendAsQueryAsync(HttpRequestInfo info, Action<HttpRequestMessage> configure = null)
        {
            if (string.IsNullOrWhiteSpace(info.Method)) { info.Method = "Get"; }

            if (info.Data != null)
            {
                info.Url += $"?{info.Data}";
            }

            return await SendAsync(info, configure: configure);
        }

        public async Task<HttpResponseMessage> SendAsJsonAsync(HttpRequestInfo info, Action<HttpRequestMessage> configure = null)
        {
            info.Content = new StringContent(info.Data, Encoding.UTF8, "application/json");
            return await SendAsync(info, configure: configure);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestInfo info, Action<HttpRequestMessage> configure = null)
        {
            var message = new HttpRequestMessage(new HttpMethod(info.Method), $"{_host}{info.Url}")
            {
                Content = info.Content
            };
            //message.Headers.Add("Authorization", IOCContainer.Resolve<ITokenAccessor>().Get());
            configure?.Invoke(message);
            return await new HttpClient().SendAsync(message);
        }

        public async Task<HttpResponseMessage> SendAsync(TestCaseDto testCase)
        {
            var message = new HttpRequestMessage(new HttpMethod(testCase.HttpMethod), $"{_host}{testCase.Url}")
            {
                //Content = info.Content
            };
            //message.Headers.Add("Authorization", IOCContainer.Resolve<ITokenAccessor>().Get());
            return await new HttpClient().SendAsync(message);
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
