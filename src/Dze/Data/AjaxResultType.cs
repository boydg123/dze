// -----------------------------------------------------------------------
//  <copyright file="AjaxResultType.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-09-01 20:36</last-date>
// -----------------------------------------------------------------------

namespace Dze.Data
{
    /// <summary>
    /// 表示 ajax 操作结果类型的枚举
    /// </summary>
    public enum AjaxResultType
    {
        /// <summary>
        /// 消息结果类型
        /// </summary>
        Info = 203,

        /// <summary>
        /// 成功结果类型
        /// </summary>
        Success = 200,

        /// <summary>
        /// 异常结果类型
        /// </summary>
        Error = 500,

        /// <summary>
        /// 用户未登录
        /// </summary>
        UnAuth = 401,

        /// <summary>
        /// 已登录，但权限不足
        /// </summary>
        Forbidden = 403,

        /// <summary>
        /// 资源未找到
        /// </summary>
        NoFound = 404,

        /// <summary>
        /// 资源被锁定
        /// </summary>
        Locked = 423
    }
}