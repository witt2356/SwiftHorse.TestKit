using SwiftHorse.Repository.EntityFrameworkCore;
using SwiftHorse.TestKit.Core.Domain;

namespace SwiftHorse.TestKit.Infrastructure.Repositories
{
    internal class IntegrationTestRepository : RepositoryBase<TestKitDbContext, IntegrationTest>, IIntegrationTestRepository
    {
        public IntegrationTestRepository(IDbContextProvider<TestKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
