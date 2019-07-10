using Abp.EntityFrameworkCore;
using Abp.Modules;
using SwiftHorse.TestKit.Core;

namespace SwiftHorse.TestKit.Infrastructure
{
    [DependsOn(typeof(CoreModule))]
    [DependsOn(typeof(AbpEntityFrameworkCoreModule))]
    public class InfrastructureModule : AbpModule
    {
    }
}
