// -----------------------------------------------------------------------
//  <copyright file="IEventBusBuilder.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-09-19 1:54</last-date>
// -----------------------------------------------------------------------

namespace Dze.EventBuses
{
    /// <summary>
    /// 定义事件总线构建器
    /// </summary>
    public interface IEventBusBuilder
    {
        /// <summary>
        /// 构建事件总线
        /// </summary>
        void Build();
    }
}