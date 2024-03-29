﻿using Dze.Core.Packs;
using Dze.EventBuses;

namespace Dze.Audits
{
    /// <summary>
    /// 审计模块基类
    /// </summary>
    [DependsOnPacks(typeof(EventBusPack))]
    public abstract class AuditPackBase : OsharpPack
    {
        /// <summary>
        /// 获取 模块级别
        /// </summary>
        public override PackLevel Level => PackLevel.Application;
    }
}