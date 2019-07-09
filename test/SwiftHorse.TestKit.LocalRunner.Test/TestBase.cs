using Microsoft.Extensions.DependencyInjection;
using SwiftHorse.TestKit.Core.DependencyInjection;

namespace SwiftHorse.TestKit.LocalRunner.Test
{
    public class TestBase
    {
        public TestBase()
        {
            var services = new ServiceCollection();
            services.AddHttpClient();
            ServiceResolver.Provider = services.BuildServiceProvider();
        }
    }
}
