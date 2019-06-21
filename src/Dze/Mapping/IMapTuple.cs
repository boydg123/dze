// -----------------------------------------------------------------------
//  <copyright file="IMapTuple.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-08-25 1:04</last-date>
// -----------------------------------------------------------------------

namespace Dze.Mapping
{
    /// <summary>
    /// 定义对象映射源与目标配对
    /// </summary>
    public interface IMapTuple
    {
        /// <summary>
        /// 执行对象映射构造
        /// </summary>
        void CreateMap();
    }
}