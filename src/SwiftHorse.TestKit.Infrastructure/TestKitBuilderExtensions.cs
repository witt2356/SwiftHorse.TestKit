using Microsoft.Extensions.DependencyInjection;
using SwiftHorse.TestKit.Core.Domain;
using SwiftHorse.TestKit.Infrastructure.Repositories;

namespace SwiftHorse.TestKit
{
    public static class TestKitBuilderExtensions
    {
        public static TestKitBuilder UseInfrastructure(this TestKitBuilder builder)
        {
            builder.ServiceCollection.AddScoped<IAppInfoRepository, AppInfoRepository>();

            return builder;
        }
    }
}
