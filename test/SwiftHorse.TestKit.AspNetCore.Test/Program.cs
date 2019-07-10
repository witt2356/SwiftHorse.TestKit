using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SwiftHorse.TestKit.AspNetCore.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args).UseUrls("http://localhost:5010").UseStartup<Startup>().Build().Run();
        }
    }
}
