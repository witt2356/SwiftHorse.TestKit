using SwiftHorse.TestKit.Core.Domain;
using SwiftHorse.TestKit.Core.IServices;
using SwiftHorse.TestKit.Core.IServices.Dtos;
using System;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core.Services
{
    internal class AppInfoService : IAppInfoService
    {
        private readonly IAppInfoRepository _appInfoRepository;

        public AppInfoService(IAppInfoRepository appInfoRepository)
        {
            _appInfoRepository = appInfoRepository;
        }

        public async Task<Guid> Save(InAppInfoSaveDto input)
        {
            var appId = input.AppId ?? Guid.Empty;
            var entity = await _appInfoRepository.FirstOrDefaultAsync(x => x.Id == appId);

            if (input.AppId == null)
            {
                entity = new AppInfo { Id = Guid.NewGuid(), Name = input.Name, Code = input.Code, Descr = input.Descr };
                await _appInfoRepository.InsertAsync(entity);
            }
            else
            {
                entity.Name = input.Name;
                entity.Code = input.Code;
                entity.Descr = input.Descr;
                await _appInfoRepository.UpdateAsync(entity);
            }
            return entity.Id;
        }
    }
}
