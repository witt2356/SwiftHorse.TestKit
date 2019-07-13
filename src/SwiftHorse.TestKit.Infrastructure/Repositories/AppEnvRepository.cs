using SwiftHorse.Repository.EntityFrameworkCore;
using SwiftHorse.TestKit.Core.Domain;
using SwiftHorse.TestKit.Infrastructure;

namespace SwiftHorse.TestKit.Core.IRepositories
{
    internal class AppEnvRepository : RepositoryBase<TestKitDbContext, AppEnv>, IAppEnvRepository
    {
        public AppEnvRepository(IDbContextProvider<TestKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
