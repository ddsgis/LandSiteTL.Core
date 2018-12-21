/// ***********************************************************************
///
/// =================================
/// CLR版本    ：4.0.30319.42000
/// 命名空间    ：LandSiteTL.Core.Options
/// 文件名称    ：DbOpion.cs
/// =================================
/// 创 建 者    ：ddsgis
/// 创建日期    ：2018/12/20 21:27:36 
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

namespace LandSiteTL.Core.Options
{
    /// <summary>
    /// 数据库连接选项
    /// <see cref="DbOpion" langword="" />
    /// </summary>
    public class DbOpion
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>
        /// 数据库类型
        /// </summary>
        public string DbType { get; set; }
    }
}
