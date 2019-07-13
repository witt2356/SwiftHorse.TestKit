using Microsoft.AspNetCore.Mvc;
using SwiftHorse.TestKit.Core.Domain;
using SwiftHorse.TestKit.Core.IServices.Dtos;
using System;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.WebApi.Controllers
{
    public class ApiInfoController : ApiControllerBase
    {
        private readonly IApiInfoRepository _apiRepository;

        public ApiInfoController(IApiInfoRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }

        [HttpPut]
        public async Task<IActionResult> BulkPersist(InApiInfoBulkPersistDto input)
        {
            foreach (var apiInfo in input.Apis)
            {
                apiInfo.Id = Guid.NewGuid();
                apiInfo.AppId = input.AppId;
                await _apiRepository.InsertAsync(apiInfo);
            }

            return Ok();
        }
    }
}
