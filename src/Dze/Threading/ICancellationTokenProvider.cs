// -----------------------------------------------------------------------
//  <copyright file="ICancellationTokenProvider.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2019 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2019-04-09 22:54</last-date>
// -----------------------------------------------------------------------

using System.Threading;


namespace Dze.Threading
{
    /// <summary>
    /// 定义异步任务取消标识提供器
    /// </summary>
    public interface ICancellationTokenProvider
    {
        /// <summary>
        /// 获取 异步任务取消标识
        /// </summary>
        CancellationToken Token { get; }
    }
}