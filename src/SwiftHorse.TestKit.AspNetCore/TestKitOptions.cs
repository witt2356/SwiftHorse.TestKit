﻿using System;

namespace SwiftHorse.TestKit.AspNetCore
{
    /// <summary>
    /// 
    /// </summary>
    public class TestKitOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public string Host { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid AppId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        internal string Url { get; } = "/api/ApiInfo/Load";
    }
}
