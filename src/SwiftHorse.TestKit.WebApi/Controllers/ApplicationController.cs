using Microsoft.AspNetCore.Mvc;
using SwiftHorse.TestKit.Core.IServices;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.WebApi.Controllers
{
    public class ApplicationController : ApiControllerBase
    {
        private readonly IAppInfoService _service;
        public ApplicationController(IAppInfoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task Save()
        {

        }

    }
}
