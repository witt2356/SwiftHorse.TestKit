using Abp.Domain.Entities;
using System;

namespace SwiftHorse.TestKit.Core.Models
{
    public class TestCase : AggregateRoot<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid ApiId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Data { get; set; }
    }
}
