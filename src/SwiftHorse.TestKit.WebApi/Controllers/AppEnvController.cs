using Microsoft.AspNetCore.Mvc;
using SwiftHorse.TestKit.Core.IServices;
using SwiftHorse.TestKit.Core.IServices.Dtos;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.WebApi.Controllers
{
    /// <summary>
    /// 应用环境
    /// </summary>
    public class AppEnvController : ApiControllerBase
    {
        private readonly IAppEnvService _service;

        public AppEnvController(IAppEnvService service)
        {
            _service = service;
        }

        /// <summary>
        /// 保存应用环境
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<OutAppEnvSaveDto> Save(InAppEnvSaveDto input)
        {
            var appId = await _service.Save(input);
            return new OutAppEnvSaveDto { EnvId = appId };
        }

    }
}
