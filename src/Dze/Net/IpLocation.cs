// -----------------------------------------------------------------------
//  <copyright file="IpLocation.cs" company="OSharp��Դ�Ŷ�">
//      Copyright (c) 2014 Dze. All rights reserved.
//  </copyright>
//  <last-editor>������</last-editor>
//  <last-date>2014-10-14 1:26</last-date>
// -----------------------------------------------------------------------

namespace Dze.Net
{
    /// <summary>
    /// IPλ����Ϣ��
    /// </summary>
    public class IpLocation
    {
        /// <summary>
        /// IP��ַ
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// IP��ַ��������
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// λ����Ϣ
        /// </summary>
        public string Local { get; set; }
    }
}