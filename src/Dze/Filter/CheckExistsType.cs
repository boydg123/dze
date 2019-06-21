// -----------------------------------------------------------------------
//  <copyright file="BinAssemblyFinder.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-08-15 23:33</last-date>
// -----------------------------------------------------------------------

namespace Dze.Filter
{
    /// <summary>
    /// 指定可用于表数据存在性检查类型的值
    /// </summary>
    public enum CheckExistsType
    {
        /// <summary>
        ///   插入数据时重复性检查
        /// </summary>
        Insert,

        /// <summary>
        ///   编辑数据时重复性检查
        /// </summary>
        Update
    }
}
