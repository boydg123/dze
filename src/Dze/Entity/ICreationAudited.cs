// -----------------------------------------------------------------------
//  <copyright file="ICreationAudited.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2019 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2019-04-12 10:25</last-date>
// -----------------------------------------------------------------------

namespace Dze.Entity
{
    /// <summary>
    /// 定义创建审计信息
    /// </summary>
    public interface ICreationAudited<TUserKey> : ICreatedTime
        where TUserKey : struct
    {
        /// <summary>
        /// 获取或设置 创建者编号
        /// </summary>
        TUserKey? CreatorId { get; set; }
    }
}