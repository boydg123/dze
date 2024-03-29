﻿// -----------------------------------------------------------------------
//  <copyright file="IHybridServiceScopeFactory.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-12-20 23:19</last-date>
// -----------------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;


namespace Dze.Dependency
{
    /// <summary>
    /// <see cref="IServiceScope"/>工厂包装一下
    /// </summary>
    public interface IHybridServiceScopeFactory : IServiceScopeFactory
    { }
}