using SwiftHorse.Repository.EntityFrameworkCore;
using SwiftHorse.TestKit.Core.Domain;

namespace SwiftHorse.TestKit.Infrastructure.Repositories
{
    internal class AppInfoRepository : RepositoryBase<TestKitDbContext, AppInfo>, IAppInfoRepository
    {
        public AppInfoRepository(IDbContextProvider<TestKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
