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

    /// <summary>
    /// 
    /// </summary>
    public class ContentTypes
    {
        /// <summary>
        /// For get or delete 
        /// </summary>
        public const string Url = "url-param";
        /// <summary>
        /// 
        /// </summary>
        public const string Json = "application/json";
        /// <summary>
        /// 
        /// </summary>
        public const string FormUrlencoded = "application/x-www-form-urlencoded";
        /// <summary>
        /// 
        /// </summary>
        public const string FormData = "multipart/form-data";
    }
}
