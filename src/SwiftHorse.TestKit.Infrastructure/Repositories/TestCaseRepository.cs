using SwiftHorse.Repository.EntityFrameworkCore;
using SwiftHorse.TestKit.Core.Domain;

namespace SwiftHorse.TestKit.Infrastructure.Repositories
{
    internal class TestCaseRepository : RepositoryBase<TestKitDbContext, TestCase>, ITestCaseRepository
    {
        public TestCaseRepository(IDbContextProvider<TestKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
