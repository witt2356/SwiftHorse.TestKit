using Microsoft.Extensions.DependencyInjection;
using SwiftHorse.TestKit.Core.Domain;
using SwiftHorse.TestKit.Infrastructure.Repositories;

namespace SwiftHorse.TestKit
{
    public static class TestKitBuilderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static TestKitBuilder UseInfrastructure(this TestKitBuilder builder)
        {
            builder.ServiceCollection.AddScoped<IAppInfoRepository, AppInfoRepository>();
            builder.ServiceCollection.AddScoped<IAppEnvRepository, AppEnvRepository>();
            builder.ServiceCollection.AddScoped<IApiInfoRepository, ApiInfoRepository>();
            builder.ServiceCollection.AddScoped<ITestCaseRepository, TestCaseRepository>();
            builder.ServiceCollection.AddScoped<IIntegrationTestRepository, IntegrationTestRepository>();

            return builder;
        }
    }
}
