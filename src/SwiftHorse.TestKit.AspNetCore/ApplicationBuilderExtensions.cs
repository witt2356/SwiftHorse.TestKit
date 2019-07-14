using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using SwiftHorse.TestKit.AspNetCore;
using SwiftHorse.TestKit.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit
{
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public static void UseTestKit(this IApplicationBuilder app)
        {
            var options = app.ApplicationServices.GetService<IOptions<TestKitOptions>>().Value;

            var apis = ExtractApis(app.ApplicationServices);
            Persist(options, apis).Wait();
        }
        private static List<InApiDto> ExtractApis(IServiceProvider serviceProvider)
        {
            var apis = new List<InApiDto>();

            var actionProvider = serviceProvider.GetService<IActionDescriptorCollectionProvider>();
            foreach (var descriptor in actionProvider.ActionDescriptors.Items)
            {
                var api = new InApiDto { Url = descriptor.AttributeRouteInfo.Template };

                foreach (var constraint in descriptor.ActionConstraints)
                {
                    if (constraint is HttpMethodActionConstraint httpMethodConstraint)
                    {
                        api.HttpMethod = httpMethodConstraint.HttpMethods.First();
                    }
                }
                if (descriptor.Parameters.Any(x => x.BindingInfo.BindingSource == BindingSource.Query))
                {
                    api.ContentType = ContentTypes.Url;
                }

                apis.Add(api);
            }

            return apis;
        }
        private static async Task Persist(TestKitOptions options, List<InApiDto> apis)
        {
            var content = JsonConvert.SerializeObject(new { options.AppId, Apis = apis });
            var httpClient = new HttpClient() { BaseAddress = new Uri(options.Host) };
            await httpClient.PutAsync(options.Url, new StringContent(content, Encoding.UTF8, ContentTypes.Json));
        }
    }

    internal class InApiDto
    {
        public string Url { get; set; }
        public string HttpMethod { get; set; }
        public string ContentType { get; set; }
    }
}
