using Microsoft.EntityFrameworkCore;
using SwiftHorse.TestKit.Core.Domain;
using SwiftHorse.TestKit.Infrastructure.Configurations;

namespace SwiftHorse.TestKit.Infrastructure
{
    public class TestKitDbContext : DbContext
    {
        public TestKitDbContext(DbContextOptions<TestKitDbContext> options) : base(options)
        {

        }

        public DbSet<AppInfo> Apps { get; set; }
        public DbSet<AppEnv> AppEnvs { get; set; }
        public DbSet<ApiInfo> Apis { get; set; }
        public DbSet<TestCase> TestCases { get; set; }
        public DbSet<IntegrationTest> IntegrationTests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppInfoConf());
            modelBuilder.ApplyConfiguration(new ApiInfoConf());
            modelBuilder.ApplyConfiguration(new TestCaseConf());
            modelBuilder.ApplyConfiguration(new IntegrationTestConf());
        }
    }
}
