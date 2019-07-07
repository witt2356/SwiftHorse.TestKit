using Abp.Modules;
using SwiftHorse.TestKit.Core;

namespace SwiftHorse.TestKit.Infrastructure
{
    [DependsOn(typeof(CoreModule))]
    public class InfrastructureModule : AbpModule
    {
    }
}
