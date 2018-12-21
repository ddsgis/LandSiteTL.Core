/// ***********************************************************************
///
/// =================================
/// CLR版本    ：4.0.30319.42000
/// 命名空间    ：LandSiteTL.Core.Models
/// 文件名称    ：DbTable.cs
/// =================================
/// 创 建 者    ：ddsgis
/// 创建日期    ：2018/12/20 20:40:05 
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
    /// 数据库中表属性
    /// <see cref="DbTable" langword="" />
    /// </summary>
    [Serializable]
    public class DbTable
    {
        /// <summary>
        /// 表名
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// 表说明
        /// </summary>
        public string TableComment { get; set; }
        /// <summary>
        /// 字段集合
        /// </summary>
        public virtual List<DbTableColumn> Columns { get; set; } = new List<DbTableColumn>();
    }
}
