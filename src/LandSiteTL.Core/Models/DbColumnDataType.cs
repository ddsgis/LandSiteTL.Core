/// ***********************************************************************
///
/// =================================
/// CLR版本    ：4.0.30319.42000
/// 命名空间    ：LandSiteTL.Core.Models
/// 文件名称    ：DbColumnDataType.cs
/// =================================
/// 创 建 者    ：ddsgis
/// 创建日期    ：2018/12/20 20:35:05 
/// 邮箱        ：691473083@qq.com
/// 个人主站    ：https://ddsgis.blogspot.com/
/// 功能描述    ：
/// 使用说明    ：
/// =================================
/// 修改者    ：
/// 修改日期    ：
/// 修改内容    ：
/// =================================
///
/// ***********************************************************************


using System;
using System.Collections.Generic;
using System.Text;

namespace LandSiteTL.Core.Models
{
    /// <summary>
    /// 数据库列的属性
    /// <see cref="DbColumnDataType" langword="" />
    /// </summary>
    public class DbColumnDataType
    {
        /// <summary>
        /// 数据库类型
        /// </summary>
        public DatabaseType DatabaseType { get; set; }

        /// <summary>
        /// 数据库中对应的类型
        /// </summary>
        public string ColumnTypes { get; set; }
        /// <summary>
        /// C#中对应的类型
        /// </summary>
        public string CSharpType { get; set; }
    }
}
