using SwiftHorse.TestKit.Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.WebApi.Queries
{
    public class AppInfoQuery
    {
        private readonly IAppInfoRepository _appInfoRepository;

        public AppInfoQuery(IAppInfoRepository appInfoRepository)
        {
            _appInfoRepository = appInfoRepository;
        }

        public async Task<IList<AppInfo>> Query()
        {
            return await _appInfoRepository.QueryAsync(x => true);
        }
    }
}
