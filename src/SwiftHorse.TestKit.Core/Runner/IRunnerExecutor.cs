using System.Threading.Tasks;

namespace SwiftHorse.TestKit.Core.Runner
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRunnerExecutor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="host"></param>
        /// <param name="testCase"></param>
        /// <returns></returns>
        Task Execute(string host, TestCaseDto testCase);
    }
}
