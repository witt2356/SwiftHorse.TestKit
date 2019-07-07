using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SwiftHorse.TestKit.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build().Run();
        }
    }
}
