using Microsoft.AspNetCore.Mvc;
using SwiftHorse.TestKit.Core.IRepositories;
using SwiftHorse.TestKit.WebApi.Dtos;
using System;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.WebApi.Controllers
{
    public class ApiInfoController : ApiControllerBase
    {
        private readonly IApiRepository _apiRepository;

        public ApiInfoController(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }

        [HttpPut]
        public async Task<IActionResult> BulkPersist(InApiInfoBulkPersistDto input)
        {
            foreach (var api in input.Apis)
            {
                api.Id = Guid.NewGuid();
                api.AppId = input.AppId;
                await _apiRepository.InsertAsync(api);
            }

            return Ok();
        }
    }
}
