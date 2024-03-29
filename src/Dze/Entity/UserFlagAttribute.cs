﻿// -----------------------------------------------------------------------
//  <copyright file="UseTagAttribute.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-07-20 0:17</last-date>
// -----------------------------------------------------------------------

using System;


namespace Dze.Entity
{
    /// <summary>
    /// 用户标记，用于标示用户属性/字段
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class UserFlagAttribute : Attribute
    { }
}