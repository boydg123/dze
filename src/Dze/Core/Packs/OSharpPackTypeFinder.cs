// -----------------------------------------------------------------------
//  <copyright file="OSharpPackTypeFinder.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-08-09 22:22</last-date>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

using Dze.Collections;
using Dze.Reflection;


namespace Dze.Core.Packs
{
    /// <summary>
    /// OSharp模块类型查找器
    /// </summary>
    public class OsharpPackTypeFinder : BaseTypeFinderBase<OsharpPack>, IOsharpPackTypeFinder
    {
        /// <summary>
        /// 初始化一个<see cref="OsharpPackTypeFinder"/>类型的新实例
        /// </summary>
        public OsharpPackTypeFinder(IAllAssemblyFinder allAssemblyFinder)
            : base(allAssemblyFinder)
        { }

        /// <summary>
        /// 重写以实现所有项的查找
        /// </summary>
        /// <returns></returns>
        protected override Type[] FindAllItems()
        {
            //排除被继承的Pack实类
            Type[] types = base.FindAllItems();
            Type[] basePackTypes = types.Select(m => m.BaseType).Where(m => m != null && m.IsClass && !m.IsAbstract).ToArray();
            return types.Except(basePackTypes).ToArray();
        }
    }
}