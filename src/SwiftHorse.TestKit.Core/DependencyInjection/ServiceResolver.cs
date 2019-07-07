using Microsoft.Extensions.DependencyInjection;
using System;

namespace SwiftHorse.TestKit.Core.DependencyInjection
{
    public class ServiceResolver
    {
        public static IServiceProvider Provider;

        public static T Resolve<T>()
        {
            return Provider.GetService<T>();
        }

        public static T CreateInstance<T>()
        {
            return ActivatorUtilities.CreateInstance<T>(Provider);
        }
    }
}
