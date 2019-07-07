using Abp.Modules;
using SwiftHorse.TestKit.Infrastructure;

namespace SwiftHorse.TestKit.WebApi
{
    [DependsOn(typeof(InfrastructureModule))]
    public class WebApiModule : AbpModule
    {
    }
}
