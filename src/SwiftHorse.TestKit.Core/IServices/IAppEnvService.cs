using System;
using System.Threading.Tasks;
using SwiftHorse.TestKit.Core.IServices.Dtos;

namespace SwiftHorse.TestKit.Core.IServices
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAppEnvService : ITestKitService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<Guid> Save(InAppEnvSaveDto input);
    }
}
