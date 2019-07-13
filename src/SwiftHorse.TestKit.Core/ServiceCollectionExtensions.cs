using Microsoft.Extensions.DependencyInjection;
using SwiftHorse.TestKit.Core.IServices;
using SwiftHorse.TestKit.Core.Services;
using System;

namespace SwiftHorse.TestKit
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configure"></param>
        public static void AddTestKit(this IServiceCollection services, Action<TestKitBuilder> configure = null)
        {
            var builder = new TestKitBuilder(services);
            configure?.Invoke(builder);

            services.AddScoped<IAppInfoService, AppInfoService>();
        }
    }
}
