using Abp.Domain.Values;
using System.Collections.Generic;

namespace SwiftHorse.TestKit.Core.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class TestCaseAssert : ValueObject
    {
        public int AssertType { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {

            yield return AssertType;
        }
    }
}
