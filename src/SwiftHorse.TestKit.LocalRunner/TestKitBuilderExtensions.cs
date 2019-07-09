using Microsoft.Extensions.DependencyInjection;
using SwiftHorse.TestKit.Core;
using SwiftHorse.TestKit.Core.Runner;

namespace SwiftHorse.TestKit.LocalRunner
{
    public static class TestKitBuilderExtensions
    {
        public static void UseLocalRunner(this TestKitBuilder builder)
        {
            builder.ServiceCollection.AddScoped<IRunnerExecutor, LocalRunnerExecutor>();
        }
    }
}
