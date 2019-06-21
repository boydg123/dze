// -----------------------------------------------------------------------
//  <copyright file="OutputDtoTypeFinder.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-08-06 10:16</last-date>
// -----------------------------------------------------------------------


using Dze.Reflection;


namespace Dze.Entity
{
    /// <summary>
    /// <see cref="IOutputDto"/>类型查找器
    /// </summary>
    public class OutputDtoTypeFinder : BaseTypeFinderBase<IOutputDto>, IOutputDtoTypeFinder
    {
        /// <summary>
        /// 初始化一个<see cref="BaseTypeFinderBase{TBaseType}"/>类型的新实例
        /// </summary>
        public OutputDtoTypeFinder(IAllAssemblyFinder allAssemblyFinder)
            : base(allAssemblyFinder)
        { }
    }
}