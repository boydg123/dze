﻿// -----------------------------------------------------------------------
//  <copyright file="IModuleHandler.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-23 2:31</last-date>
// -----------------------------------------------------------------------

namespace Dze.Core.Modules
{
    /// <summary>
    /// 定义模块信息处理器，负责在系统初始化时从程序集获取最新的模块信息，并同步到数据库中
    /// </summary>
    public interface IModuleHandler
    {
        /// <summary>
        /// 从程序集中获取模块信息
        /// </summary>
        void Initialize();
    }
}