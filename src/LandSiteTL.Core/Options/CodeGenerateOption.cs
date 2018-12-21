/// ***********************************************************************
///
/// =================================
/// CLR版本    ：4.0.30319.42000
/// 命名空间    ：LandSiteTL.Core.Options
/// 文件名称    ：CodeGenerateOption.cs
/// =================================
/// 创 建 者    ：ddsgis
/// 创建日期    ：2018/12/20 21:27:01 
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
    /// 代码生成选项
    /// <see cref="CodeGenerateOption" langword="" />
    /// </summary>
    public class CodeGenerateOption : DbOpion
    {

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 代码生成时间
        /// </summary>
        public string GeneratorTime { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        /// <summary>
        /// 输出路径
        /// </summary>
        public string OutputPath { get; set; }

        /// <summary>
        /// 实体命名空间
        /// </summary>
        public string ModelsNamespace { get; set; }
        /// <summary>
        /// 仓储接口命名空间
        /// </summary>
        public string IRepositoryNamespace { get; set; }
        /// <summary>
        /// 仓储命名空间
        /// </summary>
        public string RepositoryNamespace { get; set; }
    }
}
