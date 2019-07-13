using Microsoft.AspNetCore.Mvc;
using SwiftHorse.TestKit.Core.Domain;
using SwiftHorse.TestKit.Core.IServices;
using SwiftHorse.TestKit.Core.IServices.Dtos;
using SwiftHorse.TestKit.WebApi.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.WebApi.Controllers
{
    /// <summary>
    /// 应用
    /// </summary>
    public class AppInfoController : ApiControllerBase
    {
        private readonly AppInfoQuery _query;
        private readonly IAppInfoService _service;

        public AppInfoController(AppInfoQuery query, IAppInfoService service)
        {
            _query = query;
            _service = service;
        }

        /// <summary>
        /// 获取应用
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IList<AppInfo>> Get()
        {
            return await _query.Query();
        }

        /// <summary>
        /// 保存应用
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<OutAppInfoSaveDto> Save(InAppInfoSaveDto input)
        {
            var appId = await _service.Save(input);
            return new OutAppInfoSaveDto { AppId = appId };
        }

    }
}
