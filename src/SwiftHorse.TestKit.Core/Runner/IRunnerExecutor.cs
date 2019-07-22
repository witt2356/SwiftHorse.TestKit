using System.Collections.Generic;
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
        /// <param name="testCases"></param>
        /// <returns></returns>
        Task Execute(string host, IEnumerable<TestCaseDto> testCases);
    }
}
