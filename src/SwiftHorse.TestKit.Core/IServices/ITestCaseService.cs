using SwiftHorse.TestKit.Core.IServices.Dtos;
using System;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core.IServices
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITestCaseService : ITestKitService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<Guid> Save(InTestCaseSaveDto input);
    }
}
