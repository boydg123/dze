// -----------------------------------------------------------------------
//  <copyright file="ICacheKeyGenerator.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2016 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2016-11-16 23:41</last-date>
// -----------------------------------------------------------------------

namespace Dze.Caching
{
    /// <summary>
    /// 定义缓存键生成功能
    /// </summary>
    public interface ICacheKeyGenerator
    {
        /// <summary>
        /// 生成缓存键
        /// </summary>
        /// <param name="args">参数</param>
        /// <returns></returns>
        string GetKey(params object[] args);
    }
}