using SwiftHorse.TestKit.Core.IServices.Dtos;
using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core.IServices
{
    /// <summary>
    /// 
    /// </summary>
    public interface IApiInfoService : ITestKitService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Load(InApiInfoLoadDto input);
    }
}
