// -----------------------------------------------------------------------
//  <copyright file="IEventBus.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-01-12 14:12</last-date>
// -----------------------------------------------------------------------

namespace Dze.EventBuses
{
    /// <summary>
    /// 定义线程总线
    /// </summary>
    public interface IEventBus : IEventSubscriber, IEventPublisher
    {
        
    }
}