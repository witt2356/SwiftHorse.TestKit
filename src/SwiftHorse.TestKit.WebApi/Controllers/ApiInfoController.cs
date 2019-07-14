using Microsoft.AspNetCore.Mvc;
using SwiftHorse.TestKit.Core.IServices;
using SwiftHorse.TestKit.Core.IServices.Dtos;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.WebApi.Controllers
{
    public class ApiInfoController : ApiControllerBase
    {
        private readonly IApiInfoService _apiInfoService;

        public ApiInfoController(IApiInfoService apiInfoService)
        {
            _apiInfoService = apiInfoService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut("Load")]
        public async Task<IActionResult> Load(InApiInfoLoadDto input)
        {
            await _apiInfoService.Load(input);
            return Ok();
        }
    }
}
