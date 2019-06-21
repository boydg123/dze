﻿// -----------------------------------------------------------------------
//  <copyright file="SingletonEventHandlerFactory.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-09-19 1:34</last-date>
// -----------------------------------------------------------------------

namespace Dze.EventBuses.Internal
{
    /// <summary>
    /// 单例生命周期的事件处理器实例获取方式
    /// </summary>
    internal class SingletonEventHandlerFactory : IEventHandlerFactory
    {
        /// <summary>
        /// 初始化一个<see cref="SingletonEventHandlerFactory"/>类型的新实例
        /// </summary>
        public SingletonEventHandlerFactory(IEventHandler handler)
        {
            HandlerInstance = handler;
        }

        public IEventHandler HandlerInstance { get; }

        /// <summary>
        /// 获取事件处理器实例
        /// </summary>
        /// <returns></returns>
        public EventHandlerDisposeWrapper GetHandler()
        {
            return new EventHandlerDisposeWrapper(HandlerInstance);
        }
    }
}