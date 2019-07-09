using Microsoft.Extensions.DependencyInjection;
using System;

namespace SwiftHorse.TestKit.Core
{
    public static class ServiceCollectionExtensions
    {
        public static void AddTestKit(this IServiceCollection services, Action<TestKitBuilder> configure = null)
        {
            var builder = new TestKitBuilder(services);
            configure?.Invoke(builder);
        }
    }
}
