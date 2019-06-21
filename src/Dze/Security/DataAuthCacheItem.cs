// -----------------------------------------------------------------------
//  <copyright file="DataAuthCacheItem.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-07-05 4:24</last-date>
// -----------------------------------------------------------------------

using Dze.Filter;


namespace Dze.Security
{
    /// <summary>
    /// 数据权限缓存项
    /// </summary>
    public class DataAuthCacheItem
    {
        /// <summary>
        /// 获取或设置 角色名称
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 获取或设置 实体类型全名
        /// </summary>
        public string EntityTypeFullName { get; set; }

        /// <summary>
        /// 获取或设置 数据权限操作
        /// </summary>
        public DataAuthOperation Operation { get; set; }

        /// <summary>
        /// 获取或设置 数据过滤规则
        /// </summary>
        public FilterGroup FilterGroup { get; set; }
    }
}