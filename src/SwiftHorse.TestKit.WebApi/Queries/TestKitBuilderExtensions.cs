using Microsoft.Extensions.DependencyInjection;
using SwiftHorse.TestKit.WebApi.Queries;

namespace SwiftHorse.TestKit
{
    public static class TestKitBuilderExtensions
    {
        public static TestKitBuilder UseQuery(this TestKitBuilder builder)
        {
            builder.ServiceCollection.AddScoped<AppInfoQuery>();

            return builder;
        }
    }
}
