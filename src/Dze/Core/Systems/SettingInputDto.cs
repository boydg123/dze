// -----------------------------------------------------------------------
//  <copyright file="SettingInputDto.cs" company="OSharp��Դ�Ŷ�">
//      Copyright (c) 2014-2018 Dze. All rights reserved.
//  </copyright>
//  <site>http://www.Dze.org</site>
//  <last-editor>������</last-editor>
//  <last-date>2018-08-24 17:21</last-date>
// -----------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;


namespace Dze.Core.Systems
{
    /// <summary>
    /// ������Ϣ����DTO
    /// </summary>
    public class SettingInputDto
    {
        /// <summary>
        /// ��ȡ������ ��������ȫ��
        /// </summary>
        [Required]
        public string SettingTypeName { get; set; }

        /// <summary>
        /// ��ȡ������ ����ģ��JSON
        /// </summary>
        public string SettingJson { get; set; }
    }
}