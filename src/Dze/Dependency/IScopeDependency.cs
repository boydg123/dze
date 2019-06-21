// -----------------------------------------------------------------------
//  <copyright file="IScopeDependency.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-08-16 22:34</last-date>
// -----------------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;

namespace Dze.Dependency
{
    /// <summary>
    /// 实现此接口的类型将被注册为<see cref="ServiceLifetime.Scoped"/>模式
    /// </summary>
    [IgnoreDependency]
    public interface IScopeDependency
    { }
}