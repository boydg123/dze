// -----------------------------------------------------------------------
//  <copyright file="RedisOptions.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-12-14 17:00</last-date>
// -----------------------------------------------------------------------

namespace Dze.Core.Options
{
    /// <summary>
    /// Redis选项
    /// </summary>
    public class RedisOptions
    {
        /// <summary>
        /// 获取或设置 Redis连接配置
        /// </summary>
        public string Configuration { get; set; }

        /// <summary>
        /// 获取或设置 Redis实例名称
        /// </summary>
        public string InstanceName { get; set; }

        /// <summary>
        /// 获取或设置 是否启用
        /// </summary>
        public bool Enabled { get; set; }
    }
}