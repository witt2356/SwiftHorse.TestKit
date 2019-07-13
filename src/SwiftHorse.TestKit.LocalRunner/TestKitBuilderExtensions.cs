using Microsoft.Extensions.DependencyInjection;
using SwiftHorse.TestKit.Core.Runner;
using SwiftHorse.TestKit.LocalRunner;

namespace SwiftHorse.TestKit
{
    public static class TestKitBuilderExtensions
    {
        public static TestKitBuilder UseLocalRunner(this TestKitBuilder builder)
        {
            builder.ServiceCollection.AddHttpClient();
            builder.ServiceCollection.AddScoped<IRunnerExecutor, LocalRunnerExecutor>();

            return builder;
        }
    }
}
