using Microsoft.Extensions.DependencyInjection;

namespace SwiftHorse.TestKit.Core
{
    public class TestKitBuilder
    {
        public readonly IServiceCollection ServiceCollection;

        public TestKitBuilder(IServiceCollection services)
        {
            ServiceCollection = services;
        }
    }
}
