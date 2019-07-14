using SwiftHorse.TestKit.Core.Domain;
using SwiftHorse.TestKit.Core.IServices;
using SwiftHorse.TestKit.Core.IServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core.Services
{
    internal class ApiInfoService : IApiInfoService
    {
        private readonly IApiInfoRepository _apiInfoRepository;

        public ApiInfoService(IApiInfoRepository apiInfoRepository)
        {
            _apiInfoRepository = apiInfoRepository;
        }

        public async Task Load(InApiInfoLoadDto input)
        {
            var exists = await _apiInfoRepository.QueryAsync(x => x.AppId == input.AppId);

            var newApis = new List<ApiInfo>();
            foreach (var api in input.Apis)
            {
                if (exists.Any(x => x.Url == api.Url && x.HttpMethod == api.HttpMethod))
                {
                    continue;
                }
                api.Id = Guid.NewGuid();
                api.AppId = input.AppId;
                api.ContentType = api.ContentType ?? ContentTypes.Json;
                newApis.Add(api);
            }
            await _apiInfoRepository.BulkInsertAsync(newApis);
        }
    }
}
