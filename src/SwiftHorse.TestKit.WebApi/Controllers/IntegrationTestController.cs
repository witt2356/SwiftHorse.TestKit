using Microsoft.AspNetCore.Mvc;
using SwiftHorse.TestKit.Core.Runner;
using System;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.WebApi.Controllers
{
    /// <summary>
    /// 集成测试
    /// </summary>
    public class IntegrationTestController : ApiControllerBase
    {
        private readonly TestRunner _testRunner;

        public IntegrationTestController(TestRunner testRunner)
        {
            _testRunner = testRunner;
        }

        /// <summary>
        /// 运行集成测试
        /// </summary>
        /// <param name="envId"></param>
        /// <param name="integrationId"></param>
        /// <returns></returns>
        [HttpGet("Run")]
        public async Task<IActionResult> Run(Guid envId, Guid integrationId)
        {
            await _testRunner.RunIntegration(envId, integrationId);
            return Ok();
        }
    }
}
