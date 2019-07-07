using Abp.Domain.Entities;
using System;

namespace SwiftHorse.TestKit.Core.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Api : AggregateRoot<Guid>
    {
        /// <summary>
        /// Application Id
        /// </summary>
        public Guid AppId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HttpMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ContentType { get; set; }
    }
}
