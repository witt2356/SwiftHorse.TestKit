using Microsoft.Extensions.DependencyInjection;
using SwiftHorse.TestKit.Core.Runner;
using SwiftHorse.TestKit.LocalRunner;

namespace SwiftHorse.TestKit
{
    public static class TestKitBuilderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static TestKitBuilder UseLocalRunner(this TestKitBuilder builder)
        {
            builder.ServiceCollection.AddHttpClient();
            builder.ServiceCollection.AddScoped<IRunnerExecutor, LocalRunnerExecutor>();

            return builder;
        }
    }
}
