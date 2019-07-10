using Microsoft.Extensions.DependencyInjection;

namespace SwiftHorse.TestKit
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
