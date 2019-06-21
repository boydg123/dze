// -----------------------------------------------------------------------
//  <copyright file="EntityTypeFinder.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-08-31 2:46</last-date>
// -----------------------------------------------------------------------

using System;
using System.Linq;
using System.Reflection;
using Dze.Finders;
using Dze.Reflection;


namespace Dze.Entity
{
    /// <summary>
    /// 实体类型查找器
    /// </summary>
    public class EntityTypeFinder : FinderBase<Type>, IEntityTypeFinder
    {
        private readonly IAllAssemblyFinder _allAssemblyFinder;

        /// <summary>
        /// 初始化一个<see cref="Dze.Entity.EntityTypeFinder"/>类型的新实例
        /// </summary>
        public EntityTypeFinder(IAllAssemblyFinder allAssemblyFinder)
        {
            _allAssemblyFinder = allAssemblyFinder;
        }

        /// <summary>
        /// 重写以实现所有项的查找
        /// </summary>
        /// <returns></returns>
        protected override Type[] FindAllItems()
        {
            Type baseType = typeof(IEntity<>);
            Assembly[] assemblies = _allAssemblyFinder.FindAll(true);
            return assemblies.SelectMany(assembly => assembly.GetTypes())
                .Where(type => type.IsDeriveClassFrom(baseType)).Distinct().ToArray();
        }
    }
}