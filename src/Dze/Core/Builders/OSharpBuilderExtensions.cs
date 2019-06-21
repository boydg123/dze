// -----------------------------------------------------------------------
//  <copyright file="OsharpBuilderExtensions.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-07-02 14:27</last-date>
// -----------------------------------------------------------------------

using Dze.Core.Packs;


namespace Dze.Core.Builders
{
    /// <summary>
    /// IOSharpBuilder扩展方法
    /// </summary>
    public static class OsharpBuilderExtensions
    {
        /// <summary>
        /// 添加CorePack
        /// </summary>
        public static IOsharpBuilder AddCorePack(this IOsharpBuilder builder)
        {
            return builder.AddPack<OsharpCorePack>();
        }
    }
}