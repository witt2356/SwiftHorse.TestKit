using SwiftHorse.TestKit.Core.Domain;
using SwiftHorse.TestKit.Core.IServices;
using SwiftHorse.TestKit.Core.IServices.Dtos;
using System;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core.Services
{
    internal class AppEnvService : IAppEnvService
    {
        private readonly IAppEnvRepository _appEnvRepository;

        public AppEnvService(IAppEnvRepository appEnvRepository)
        {
            _appEnvRepository = appEnvRepository;
        }

        public async Task<Guid> Save(InAppEnvSaveDto input)
        {
            var envId = input.EnvId ?? Guid.Empty;
            var entity = await _appEnvRepository.FirstOrDefaultAsync(x => x.Id == envId);

            if (input.EnvId == null)
            {
                entity = new AppEnv { Id = Guid.NewGuid(), AppId = input.AppId, Host = input.Host };
                await _appEnvRepository.InsertAsync(entity);
            }
            else
            {
                entity.AppId = input.AppId;
                entity.Host = input.Host;
                await _appEnvRepository.UpdateAsync(entity);
            }
            return entity.Id;
        }
    }
}
