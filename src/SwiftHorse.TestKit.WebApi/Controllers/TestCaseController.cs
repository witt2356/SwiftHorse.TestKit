using Microsoft.AspNetCore.Mvc;
using SwiftHorse.TestKit.Core.IServices;
using SwiftHorse.TestKit.Core.IServices.Dtos;
using SwiftHorse.TestKit.Core.Runner;
using System;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.WebApi.Controllers
{
    /// <summary>
    /// 测试用例
    /// </summary>
    public class TestCaseController : ApiControllerBase
    {
        private readonly ITestCaseService _testCaseService;
        private readonly TestRunner _testRunner;

        public TestCaseController(ITestCaseService testCaseService, TestRunner testRunner)
        {
            _testCaseService = testCaseService;
            _testRunner = testRunner;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<OutTestCaseSaveDto> Save(InTestCaseSaveDto input)
        {
            var caseId = await _testCaseService.Save(input);
            return new OutTestCaseSaveDto { CaseId = caseId };
        }

        /// <summary>
        /// 运行测试用例
        /// </summary>
        /// <param name="envId"></param>
        /// <param name="caseId"></param>
        /// <returns></returns>
        [HttpGet("Run")]
        public async Task<IActionResult> Run(Guid envId, Guid caseId)
        {
            await _testRunner.RunSingle(envId, caseId);
            return Ok();
        }
    }
}
