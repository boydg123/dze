﻿// -----------------------------------------------------------------------
//  <copyright file="MapToAttribute.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-09-14 0:24</last-date>
// -----------------------------------------------------------------------

using System;

using Dze.Data;


namespace Dze.Mapping
{
    /// <summary>
    /// 标注当前类型映射到目标类型的Mapping映射关系
    /// </summary>
    public class MapToAttribute : Attribute
    {
        /// <summary>
        /// 初始化一个<see cref="MapToAttribute"/>类型的新实例
        /// </summary>
        public MapToAttribute(params Type[] targetTypes)
        {
            Check.NotNull(targetTypes, nameof(targetTypes));
            TargetTypes = targetTypes;
        }

        /// <summary>
        /// 目标类型
        /// </summary>
        public Type[] TargetTypes { get; }
    }
}