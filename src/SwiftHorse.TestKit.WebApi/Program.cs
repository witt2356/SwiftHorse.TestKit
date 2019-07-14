using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace SwiftHorse.TestKit.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args).UseUrls(GetUrls()).UseStartup<Startup>().Build().Run();
        }

        private static string GetUrls()
        {
            var urls = new ConfigurationBuilder().AddEnvironmentVariables().Build()["SERVER_URLS"];
            return string.IsNullOrWhiteSpace(urls) ? "http://*:5000" : urls;
        }
    }
}
