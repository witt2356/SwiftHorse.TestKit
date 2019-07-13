using SwiftHorse.Repository.EntityFrameworkCore;
using SwiftHorse.TestKit.Core.Domain;

namespace SwiftHorse.TestKit.Infrastructure.Repositories
{
    internal class ApiInfoRepository : RepositoryBase<TestKitDbContext, ApiInfo>, IApiInfoRepository
    {
        public ApiInfoRepository(IDbContextProvider<TestKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
