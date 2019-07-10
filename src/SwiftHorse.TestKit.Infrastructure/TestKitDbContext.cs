using Microsoft.EntityFrameworkCore;

namespace SwiftHorse.TestKit.Infrastructure
{
    public class TestKitDbContext : DbContext
    {
        public TestKitDbContext(DbContextOptions<TestKitDbContext> options) : base(options)
        {

        }
    }
}
