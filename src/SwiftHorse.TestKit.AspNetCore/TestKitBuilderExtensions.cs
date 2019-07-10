using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SwiftHorse.TestKit.AspNetCore;
using SwiftHorse.TestKit.Core;
using System;

namespace SwiftHorse.TestKit
{
    public static class TestKitBuilderExtensions
    {
        public static void UseAspNetCore(this TestKitBuilder builder, Action<TestKitOptions> configure)
        {
            builder.ServiceCollection.Configure(configure);
        }

        public static void UseAspNetCore(this TestKitBuilder builder, IConfiguration configuration)
        {
            builder.ServiceCollection.Configure<TestKitOptions>(configuration);
        }
    }
}
