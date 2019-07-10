using SwiftHorse.TestKit.Core.Models;
using System;
using System.Collections.Generic;

namespace SwiftHorse.TestKit.WebApi.Dtos
{
    public class InApiInfoBulkPersistDto
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid AppId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Api> Apis { get; set; }
    }
}
