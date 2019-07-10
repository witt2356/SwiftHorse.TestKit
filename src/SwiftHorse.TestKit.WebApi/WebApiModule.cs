using Abp.AspNetCore;
using Abp.Modules;
using SwiftHorse.TestKit.Infrastructure;

namespace SwiftHorse.TestKit.WebApi
{
    [DependsOn(typeof(InfrastructureModule))]
    [DependsOn(typeof(AbpAspNetCoreModule))]
    public class WebApiModule : AbpModule
    {
    }
}
