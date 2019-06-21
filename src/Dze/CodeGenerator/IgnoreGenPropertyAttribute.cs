// -----------------------------------------------------------------------
//  <copyright file="IgnoreGenPropertyAttribute.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-08-06 13:08</last-date>
// -----------------------------------------------------------------------

using System;


namespace Dze.CodeGenerator
{
    /// <summary>
    /// 标记要在CodeGenerator生成代码时忽略的属性
    /// </summary>
    public class IgnoreGenPropertyAttribute : Attribute
    { }
}